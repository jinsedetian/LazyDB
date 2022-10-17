namespace LazyDB
{
    partial class ExportConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.number = new System.Windows.Forms.CheckBox();
            this.EngName = new System.Windows.Forms.CheckBox();
            this.Type = new System.Windows.Forms.CheckBox();
            this.ChsName = new System.Windows.Forms.CheckBox();
            this.Required = new System.Windows.Forms.CheckBox();
            this.DefaultValue = new System.Windows.Forms.CheckBox();
            this.EngNameBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(10, 211);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(281, 45);
            this.Save_Btn.TabIndex = 34;
            this.Save_Btn.Text = "保存";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(23, 14);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(48, 16);
            this.number.TabIndex = 39;
            this.number.Text = "序号";
            this.number.UseVisualStyleBackColor = true;
            // 
            // EngName
            // 
            this.EngName.AutoSize = true;
            this.EngName.Location = new System.Drawing.Point(23, 45);
            this.EngName.Name = "EngName";
            this.EngName.Size = new System.Drawing.Size(84, 16);
            this.EngName.TabIndex = 40;
            this.EngName.Text = "字段英文名";
            this.EngName.UseVisualStyleBackColor = true;
            this.EngName.CheckedChanged += new System.EventHandler(this.EngName_CheckedChanged);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(77, 14);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(48, 16);
            this.Type.TabIndex = 41;
            this.Type.Text = "类型";
            this.Type.UseVisualStyleBackColor = true;
            // 
            // ChsName
            // 
            this.ChsName.AutoSize = true;
            this.ChsName.Location = new System.Drawing.Point(23, 144);
            this.ChsName.Name = "ChsName";
            this.ChsName.Size = new System.Drawing.Size(96, 16);
            this.ChsName.TabIndex = 42;
            this.ChsName.Text = "字段中文名称";
            this.ChsName.UseVisualStyleBackColor = true;
            // 
            // Required
            // 
            this.Required.AutoSize = true;
            this.Required.Location = new System.Drawing.Point(131, 144);
            this.Required.Name = "Required";
            this.Required.Size = new System.Drawing.Size(48, 16);
            this.Required.TabIndex = 43;
            this.Required.Text = "必填";
            this.Required.UseVisualStyleBackColor = true;
            // 
            // DefaultValue
            // 
            this.DefaultValue.AutoSize = true;
            this.DefaultValue.Location = new System.Drawing.Point(191, 144);
            this.DefaultValue.Name = "DefaultValue";
            this.DefaultValue.Size = new System.Drawing.Size(60, 16);
            this.DefaultValue.TabIndex = 44;
            this.DefaultValue.Text = "默认值";
            this.DefaultValue.UseVisualStyleBackColor = true;
            // 
            // EngNameBox
            // 
            this.EngNameBox.CheckOnClick = true;
            this.EngNameBox.FormattingEnabled = true;
            this.EngNameBox.Items.AddRange(new object[] {
            "转换为下划线格式",
            "转换为大驼峰格式",
            "转换为小驼峰格式"});
            this.EngNameBox.Location = new System.Drawing.Point(113, 43);
            this.EngNameBox.Name = "EngNameBox";
            this.EngNameBox.Size = new System.Drawing.Size(138, 52);
            this.EngNameBox.TabIndex = 45;
            this.EngNameBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EngNameBox_ItemCheck);
            // 
            // ExportConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(303, 277);
            this.Controls.Add(this.EngNameBox);
            this.Controls.Add(this.DefaultValue);
            this.Controls.Add(this.Required);
            this.Controls.Add(this.ChsName);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.EngName);
            this.Controls.Add(this.number);
            this.Controls.Add(this.Save_Btn);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "ExportConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库配置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExportConfig_FormClosed);
            this.Load += new System.EventHandler(this.ExportConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox number;
        private System.Windows.Forms.CheckBox EngName;
        private System.Windows.Forms.CheckBox Type;
        private System.Windows.Forms.CheckBox ChsName;
        private System.Windows.Forms.CheckBox Required;
        private System.Windows.Forms.CheckBox DefaultValue;
        private System.Windows.Forms.CheckedListBox EngNameBox;
    }
}