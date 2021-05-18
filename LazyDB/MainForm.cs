﻿using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string connsql
        {
            get
            {
                return $"Data Source={ConfigurationManager.AppSettings["DbIP"]};Initial Catalog={ConfigurationManager.AppSettings["DbName"]};Persist Security Info=True;User ID={ConfigurationManager.AppSettings["DbUserName"]};Password={ConfigurationManager.AppSettings["DbPwd"]}";
            }
        }

        private void DBSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var config = SingletonHelper<DBConfig>.CreateInstance(null);
            config.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonHelper<MainForm>.Dispose();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var count = 0;
            try
            {
                StringBuilder sqlBuilder = new StringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connsql;
                    conn.Open(); // 打开数据库连接
                    string sql = @"SELECT ('EXECUTE '+Case when G.[value] is null then'sp_addextendedproperty'else 'sp_updateextendedproperty' end +' N''MS_Description'', N''' + @Chs + ''', N''user'', N''dbo'', N''table'', N''' + D.name + ''', N''column'', N''' + @Eng  +'''') as text 
FROM syscolumns A
inner join 
 sysobjects D
 On A.id=D.id  and D.xtype='U' and  D.name<>'dtproperties'
Left Join
 sys.extended_properties  G
 on
     A.id=G.major_id and A.colid=G.minor_id
where 
--D.xtype='U' and  D.name<>'dtproperties' and
A.[name]=@Eng
order by D.name"; // 查询语句

                    SqlCommand myda = new SqlCommand(sql, conn);
                    myda.Parameters.Add(new SqlParameter("@Eng", SqlDbType.NVarChar, 100));
                    myda.Parameters.Add(new SqlParameter("@Chs", SqlDbType.NVarChar, 100));
                    myda.Parameters["@Eng"].Value = EngTextBox.Text;
                    myda.Parameters["@Chs"].Value = ChsTextBox.Text;
                    var reader = myda.ExecuteReader();
                    while (reader.Read())
                    {
                        count++;
                        sqlBuilder.Append(reader[0].ToString() + "\r");
                    }
                }
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connsql;
                    conn.Open(); // 打开数据库连接
                    SqlCommand sqlcmd = new SqlCommand(sqlBuilder.ToString(), conn);//创建 Command 对象
                    sqlcmd.CommandText = sqlBuilder.ToString();
                    sqlcmd.Parameters.Add(new SqlParameter("@Eng", SqlDbType.NVarChar, 100));
                    sqlcmd.Parameters.Add(new SqlParameter("@Chs", SqlDbType.NVarChar, 100));
                    sqlcmd.Parameters["@Eng"].Value = EngTextBox.Text;
                    sqlcmd.Parameters["@Chs"].Value = ChsTextBox.Text;
                    var result = sqlcmd.ExecuteNonQuery();
                    conn.Close(); // 关闭数据库连接
                    MessageBox.Show(result.ToString() + "and" + count.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误信息：" + ex.Message, "出现错误");
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

            try
            {
                using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
                {
                    saveFileDialog1.Title = "另存为";
                    saveFileDialog1.FileName = "数据库结构.docx"; //设置默认另存为的名字，可选
                    saveFileDialog1.Filter = "Word 文件(*.docx)|*.docx|所有文件(*.*)|*.*";
                    saveFileDialog1.AddExtension = true;
                    saveFileDialog1.FilterIndex = 1;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {

                        var data = new List<TableStruct>();

                        using (SqlConnection conn = new SqlConnection())
                        {
                            conn.ConnectionString = connsql;
                            conn.Open(); // 打开数据库连接
                            string sql = @"
SELECT 
     FormName       = D.name,
     ColName     = A.name,
     Type       = B.name,
	 ColDes   = isnull(G.[value],''),
	 表说明     = Case When A.colorder=1 Then isnull(F.value,'') Else '' End,
     Number   = A.colorder,
     标识       = Case When COLUMNPROPERTY( A.id,A.name,'IsIdentity')=1 Then 1 Else 0 End,
	 主键       = Case When exists(SELECT 1 FROM sysobjects Where xtype='PK' and parent_obj=A.id and name in (
                      SELECT name FROM sysindexes WHERE indid in( SELECT indid FROM sysindexkeys WHERE id = A.id AND colid=A.colid))) then 1 else 0 end,
     占用字节数 = A.Length,
     长度       = COLUMNPROPERTY(A.id,A.name,'PRECISION'),
     小数位数   = isnull(COLUMNPROPERTY(A.id,A.name,'Scale'),0),
     IsNullAble     = Case When A.isnullable=1 Then 1 Else 0 End,
     DefaultValue     = isnull(E.Text,'')
 FROM
     syscolumns A
 Left Join
     systypes B
 On
     A.xusertype=B.xusertype
 Inner Join
     sysobjects D
 On
     A.id=D.id  and D.xtype='U' and  D.name<>'dtproperties'
 Left Join
     syscomments E
 on
     A.cdefault=E.id
 Left Join
 sys.extended_properties  G
 on
     A.id=G.major_id and A.colid=G.minor_id
 Left Join
 sys.extended_properties F
 On
     D.id=F.major_id and F.minor_id=0
 Order By
     D.[name],A.id,A.colorder"; // 查询语句

                            SqlCommand myda = new SqlCommand(sql, conn);
                            var reader = myda.ExecuteReader();
                            while (reader.Read())
                            {
                                data.Add(Change<TableStruct>(reader));
                            }
                        }

                        var output = data.GroupBy(w => w.FormName).ToList();
                        XWPFDocument doc = new XWPFDocument();
                        var properties = typeof(TableStruct).GetProperties().Where(w => w.GetCustomAttribute<DisplayNameAttribute>() != null).ToList();
                        foreach (var item in output)
                        {
                            var temp = item.ToList();
                            var Paragraph = doc.CreateParagraph();
                            Paragraph.Alignment = ParagraphAlignment.CENTER;
                            XWPFRun rUserHead = Paragraph.CreateRun();
                            rUserHead.SetText($"表{item.Key}（）");
                            //rUserHead.AddCarriageReturn();
                            var Table = doc.CreateTable(item.Count() + 1, properties.Count());
                            Table.Width = 5000;

                            for (var i = 0; i < properties.Count(); i++)
                            {
                                var displayName = properties[i].GetCustomAttribute<DisplayNameAttribute>();
                                //if (displayName != null)
                                Table.Rows[0].GetCell(i).SetText(displayName.DisplayName);
                            }
                            for (var i = 0; i < temp.Count; i++)
                            {
                                Table.Rows[i + 1].GetCell(0).SetText(temp[i].Number.ToString());
                                Table.Rows[i + 1].GetCell(1).SetText(temp[i].ColName);
                                Table.Rows[i + 1].GetCell(2).SetText(temp[i].Type);
                                Table.Rows[i + 1].GetCell(3).SetText(temp[i].ColDes);
                                Table.Rows[i + 1].GetCell(4).SetText(temp[i].IsNullAble == 1 ? "N" : "Y");
                                Table.Rows[i + 1].GetCell(5).SetText(temp[i].DefaultValue);
                            }
                            for (var i = 0; i < properties.Count(); i++)
                            {
                                var tcpr = Table.GetRow(0).GetCell(i).GetCTTc().AddNewTcPr();
                                tcpr.tcW = new CT_TblWidth();
                                tcpr.tcW.type = ST_TblWidth.auto;
                            }
                        }
                        using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write))
                        {
                            doc.Write(fs);
                        }
                        MessageBox.Show("成功导出数据！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误信息：" + ex.Message, "出现错误");
                return;
            }
        }

        public T Change<T>(SqlDataReader reader) where T : new()
        {
            var model = new T();
            try
            {
                var properties = typeof(T).GetProperties();
                foreach (var Propertie in properties)
                {
                    if (Propertie.CanRead && Propertie.CanWrite)
                    {
                        Propertie.SetValue(model, reader[Propertie.Name], null);
                    }
                }
                return model;
            }
            catch (Exception ex)
            {
                return model;
            }
        }
    }
}
