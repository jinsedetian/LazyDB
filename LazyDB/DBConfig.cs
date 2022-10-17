using Newtonsoft.Json;
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
        private SystemConfigModel Config = new SystemConfigModel();
        public DBConfig()
        {
            InitializeComponent();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            Config.ip = DbIP_TBox.Text;
            Config.dbName = DbName_TBox.Text;
            Config.userName = DbUserName_TBox.Text;
            Config.password = DbPwd_TBox.Text;
            Config.appId = appidBox.Text;
            Config.code = codeBox.Text;
            try
            {
                JsonHelper.WriteFile(JsonConvert.SerializeObject(Config, Formatting.Indented));
                MessageBox.Show("保存成功");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败\n" + ex.Message);
            }
        }
        private void DbConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonHelper<DBConfig>.Dispose();
        }

        private void LoadAppConfig()
        {
            DbIP_TBox.Text = Config.ip;
            DbName_TBox.Text = Config.dbName;
            DbUserName_TBox.Text = Config.userName;
            DbPwd_TBox.Text = Config.password;
            appidBox.Text = Config.appId;
            codeBox.Text = Config.code;
        }

        private void DBConfig_Load(object sender, EventArgs e)
        {
            Config = JsonHelper.ReadConfigJson();
            LoadAppConfig();
        }
    }
}
