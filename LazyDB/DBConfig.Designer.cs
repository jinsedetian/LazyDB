namespace LazyDB
{
    partial class DBConfig
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
            this.lbDBPwd = new System.Windows.Forms.Label();
            this.DbPwd_TBox = new System.Windows.Forms.TextBox();
            this.lbDBUser = new System.Windows.Forms.Label();
            this.DbUserName_TBox = new System.Windows.Forms.TextBox();
            this.lbDBName = new System.Windows.Forms.Label();
            this.DbName_TBox = new System.Windows.Forms.TextBox();
            this.lbDBSource = new System.Windows.Forms.Label();
            this.DbIP_TBox = new System.Windows.Forms.TextBox();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbDBPwd
            // 
            this.lbDBPwd.AutoSize = true;
            this.lbDBPwd.Location = new System.Drawing.Point(12, 99);
            this.lbDBPwd.Name = "lbDBPwd";
            this.lbDBPwd.Size = new System.Drawing.Size(77, 12);
            this.lbDBPwd.TabIndex = 29;
            this.lbDBPwd.Text = "数据库密码：";
            // 
            // DbPwd_TBox
            // 
            this.DbPwd_TBox.Location = new System.Drawing.Point(95, 96);
            this.DbPwd_TBox.Name = "DbPwd_TBox";
            this.DbPwd_TBox.PasswordChar = '*';
            this.DbPwd_TBox.Size = new System.Drawing.Size(200, 21);
            this.DbPwd_TBox.TabIndex = 28;
            this.DbPwd_TBox.Text = "";
            this.toolTip1.SetToolTip(this.DbPwd_TBox, "数据库密码");
            // 
            // lbDBUser
            // 
            this.lbDBUser.AutoSize = true;
            this.lbDBUser.Location = new System.Drawing.Point(12, 70);
            this.lbDBUser.Name = "lbDBUser";
            this.lbDBUser.Size = new System.Drawing.Size(77, 12);
            this.lbDBUser.TabIndex = 27;
            this.lbDBUser.Text = "数据库帐号：";
            // 
            // DbUserName_TBox
            // 
            this.DbUserName_TBox.Location = new System.Drawing.Point(95, 67);
            this.DbUserName_TBox.Name = "DbUserName_TBox";
            this.DbUserName_TBox.Size = new System.Drawing.Size(200, 21);
            this.DbUserName_TBox.TabIndex = 26;
            this.DbUserName_TBox.Text = "sa";
            this.toolTip1.SetToolTip(this.DbUserName_TBox, "数据库账号");
            // 
            // lbDBName
            // 
            this.lbDBName.AutoSize = true;
            this.lbDBName.Location = new System.Drawing.Point(12, 41);
            this.lbDBName.Name = "lbDBName";
            this.lbDBName.Size = new System.Drawing.Size(77, 12);
            this.lbDBName.TabIndex = 25;
            this.lbDBName.Text = "数据库名称：";
            // 
            // DbName_TBox
            // 
            this.DbName_TBox.Location = new System.Drawing.Point(95, 38);
            this.DbName_TBox.Name = "DbName_TBox";
            this.DbName_TBox.Size = new System.Drawing.Size(200, 21);
            this.DbName_TBox.TabIndex = 24;
            this.DbName_TBox.Text = "";
            this.toolTip1.SetToolTip(this.DbName_TBox, "要连接的数据库名称");
            // 
            // lbDBSource
            // 
            this.lbDBSource.AutoSize = true;
            this.lbDBSource.Location = new System.Drawing.Point(12, 12);
            this.lbDBSource.Name = "lbDBSource";
            this.lbDBSource.Size = new System.Drawing.Size(77, 12);
            this.lbDBSource.TabIndex = 23;
            this.lbDBSource.Text = "数据库地址：";
            // 
            // DbIP_TBox
            // 
            this.DbIP_TBox.Location = new System.Drawing.Point(95, 9);
            this.DbIP_TBox.Name = "DbIP_TBox";
            this.DbIP_TBox.Size = new System.Drawing.Size(200, 21);
            this.DbIP_TBox.TabIndex = 22;
            this.DbIP_TBox.Text = "";
            this.toolTip1.SetToolTip(this.DbIP_TBox, "要连接的数据库IP地址，如为本地数据库则填.");
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
            // DBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(303, 277);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.lbDBPwd);
            this.Controls.Add(this.DbPwd_TBox);
            this.Controls.Add(this.lbDBUser);
            this.Controls.Add(this.DbUserName_TBox);
            this.Controls.Add(this.lbDBName);
            this.Controls.Add(this.DbName_TBox);
            this.Controls.Add(this.lbDBSource);
            this.Controls.Add(this.DbIP_TBox);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "DBConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库配置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DbConfig_FormClosed);
            this.Load += new System.EventHandler(this.DBConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDBPwd;
        private System.Windows.Forms.TextBox DbPwd_TBox;
        private System.Windows.Forms.Label lbDBUser;
        private System.Windows.Forms.TextBox DbUserName_TBox;
        private System.Windows.Forms.Label lbDBName;
        private System.Windows.Forms.TextBox DbName_TBox;
        private System.Windows.Forms.Label lbDBSource;
        private System.Windows.Forms.TextBox DbIP_TBox;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}