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

        public DBConfig(SystemConfigModel config)
        {
            InitializeComponent();
            Config = config;
            DbIP_TBox.Text = Config.ip;
            DbName_TBox.Text = Config.dbName;
            DbUserName_TBox.Text = Config.userName;
            DbPwd_TBox.Text = Config.password;
        }

        #region 窗体操作
        private void DbIP_PBox_Click(object sender, EventArgs e)
        {
            DbIP_TBox.Enabled = true;
            DbIP_TBox.ReadOnly = false;
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            Config.ip = DbIP_TBox.Text;
            Config.dbName = DbName_TBox.Text;
            Config.userName = DbUserName_TBox.Text;
            Config.password = DbPwd_TBox.Text;
            Config.appId = appidBox.Text;
            Config.code = codeBox.Text;
            if (JsonHelper.WriteFile(JsonConvert.SerializeObject(Config, Formatting.Indented)))
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
            DbIP_TBox.Text = Config.ip;
            DbName_TBox.Text = Config.dbName;
            DbUserName_TBox.Text = Config.userName;
            DbPwd_TBox.Text = Config.password;
            appidBox.Text = Config.appId;
            codeBox.Text = Config.code;
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
            catch (Exception ex)
            {
                b = false;
            }
            return b;
        }
        #endregion

        private void DBConfig_Load(object sender, EventArgs e)
        {
            Config = JsonHelper.ReadConfigJson();
            LoadAppConfig();
        }
    }
}
