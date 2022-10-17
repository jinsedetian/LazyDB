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

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            Config.Number = number.Checked;
            if (!EngName.Checked)
                Config.EngName = "None";
            else
            {
                if (EngNameBox.SelectedIndex == 0)
                    Config.EngName = "ToDownLine";
                if (EngNameBox.SelectedIndex == 1)
                    Config.EngName = "ToUpperCamelCase";
                if (EngNameBox.SelectedIndex == 2)
                    Config.EngName = "ToLowerCamelCase";
            }
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
            if (Config.EngName != "None")
            {
                EngName.Checked = true;
                EngNameBox.Enabled = true;
                var i = 0;
                switch (Config.EngName)
                {
                    case "ToDownLine":
                        i = 0;
                        break;
                    case "ToUpperCamelCase":
                        i = 0;
                        break;
                    case "ToLowerCamelCase":
                        i = 0;
                        break;
                }
                EngNameBox.SetItemCheckState(i,
                    System.Windows.Forms.CheckState.Checked);
            }
            else
            {
                EngName.Checked = false;
                EngNameBox.Enabled = false;
            }
            EngName.Checked = Config.EngName != "None" ? true : false;
            Type.Checked = Config.Type;
            ChsName.Checked = Config.ChsName;
            Required.Checked = Config.Required;
            DefaultValue.Checked = Config.DefaultValue;
        }
        #endregion

        private void ExportConfig_Load(object sender, EventArgs e)
        {
            Config = JsonHelper.ReadConfigJson();
            LoadAppConfig();
        }

        private void EngName_CheckedChanged(object sender, EventArgs e)
        {
            if (EngName.Checked)
                EngNameBox.Enabled = true;
            else
            {
                EngNameBox.Enabled = false;
                for (int i = 0; i < EngNameBox.Items.Count; i++)
                {
                    this.EngNameBox.SetItemCheckState(i,
                        System.Windows.Forms.CheckState.Unchecked);
                }
            }
        }

        private void EngNameBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < EngNameBox.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    this.EngNameBox.SetItemCheckState(i,
                    System.Windows.Forms.CheckState.Unchecked);
                }
            }
        }
    }
}
