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
    public partial class ExportConfig : Form
    {
        private SystemConfigModel Config = new SystemConfigModel();
        public ExportConfig()
        {
            InitializeComponent();
        }

        public ExportConfig(SystemConfigModel config)
        {
            InitializeComponent();
            Config = config;
            number.Checked = Config.Number;
            EngName.Checked = Config.EngName == "Normal" ? true : false;
            Type.Checked = Config.Type;
            ChsName.Checked = Config.ChsName;
            Required.Checked = Config.Required;
            DefaultValue.Checked = Config.DefaultValue;
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            Config.Number = number.Checked;
            Config.EngName = EngName.Checked ? "Normal" : "None";
            Config.Type = Type.Checked;
            Config.ChsName = ChsName.Checked;
            Config.Required = Required.Checked;
            Config.DefaultValue = DefaultValue.Checked;
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
        private void ExportConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonHelper<ExportConfig>.Dispose();
        }

        #region 保存配置
        private void LoadAppConfig()
        {
            number.Checked = Config.Number;
            EngName.Checked = Config.EngName == "Normal" ? true : false;
            Type.Checked = Config.Type;
            ChsName.Checked = Config.ChsName;
            Required.Checked = Config.Required;
            DefaultValue.Checked = Config.DefaultValue;
        }
        private bool WriteAppConfig()
        {
            bool b = true;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("OrderNo", number.Checked.ToString());
            dic.Add("EngName", EngName.Checked.ToString());
            dic.Add("Type", Type.Checked.ToString());
            dic.Add("ChsName", ChsName.Checked.ToString());
            dic.Add("Required", Required.Checked.ToString());
            dic.Add("DefaultValue", DefaultValue.Checked.ToString());
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

        private void ExportConfig_Load(object sender, EventArgs e)
        {
            Config = JsonHelper.ReadConfigJson();
            LoadAppConfig();
        }
    }
}
