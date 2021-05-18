using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LazyDB
{
    public partial class DBConfig : Form
    {
        public DBConfig()
        {
            InitializeComponent();
        }

        #region 窗体操作
        private void DbIP_PBox_Click(object sender, EventArgs e)
        {
            DbIP_TBox.Enabled = true;
            DbIP_TBox.ReadOnly = false;
        }

        private void DbName_PBox_Click(object sender, EventArgs e)
        {
            DbName_TBox.Enabled = true;
            DbName_TBox.ReadOnly = false;
        }

        private void DbUserName_PBox_Click(object sender, EventArgs e)
        {
            DbUserName_TBox.Enabled = true;
            DbUserName_TBox.ReadOnly = false;
        }

        private void DbPwd_PBox_Click(object sender, EventArgs e)
        {
            DbPwd_TBox.Enabled = true;
            DbPwd_TBox.ReadOnly = false;
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if (WriteAppConfig())
            {
                MessageBox.Show("保存成功");
                Close();
            }
            else
            {
                MessageBox.Show("保存失败");
            }
        }
        private void DbConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonHelper<DBConfig>.Dispose();
        }
        #endregion

        #region 保存配置
        private void LoadAppConfig()
        {
            DbIP_TBox.Text = ConfigurationManager.AppSettings["DbIP"];
            DbName_TBox.Text = ConfigurationManager.AppSettings["DbName"];
            DbUserName_TBox.Text = ConfigurationManager.AppSettings["DbUserName"];
            DbPwd_TBox.Text = ConfigurationManager.AppSettings["DbPwd"];
        }
        private bool WriteAppConfig()
        {
            bool b = true;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("DbIP", DbIP_TBox.Text);
            dic.Add("DbName", DbName_TBox.Text);
            dic.Add("DbUserName", DbUserName_TBox.Text);
            dic.Add("DbPwd", DbPwd_TBox.Text);
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                foreach (KeyValuePair<string, string> kv in dic)
                {
                    if (config.AppSettings.Settings[kv.Key] == null)
                        config.AppSettings.Settings.Add(kv.Key, kv.Value);
                    else
                        config.AppSettings.Settings[kv.Key].Value = kv.Value;
                }
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch(Exception ex)
            {
                b = false;
            }
            return b;
        }
        #endregion

        private void DBConfig_Load(object sender, EventArgs e)
        {
            LoadAppConfig();
        }
    }
}
