﻿
namespace LazyDB
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基本设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DBSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.百度翻译ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EngLabel = new System.Windows.Forms.Label();
            this.ChsLabel = new System.Windows.Forms.Label();
            this.EngTextBox = new System.Windows.Forms.TextBox();
            this.ChsTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基本设置ToolStripMenuItem
            // 
            this.基本设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DBSetToolStripMenuItem,
            this.百度翻译ToolStripMenuItem});
            this.基本设置ToolStripMenuItem.Name = "基本设置ToolStripMenuItem";
            this.基本设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基本设置ToolStripMenuItem.Text = "基本设置";
            // 
            // DBSetToolStripMenuItem
            // 
            this.DBSetToolStripMenuItem.Name = "DBSetToolStripMenuItem";
            this.DBSetToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.DBSetToolStripMenuItem.Text = "数据库配置";
            this.DBSetToolStripMenuItem.Click += new System.EventHandler(this.DBSetToolStripMenuItem_Click);
            // 
            // 百度翻译ToolStripMenuItem
            // 
            this.百度翻译ToolStripMenuItem.Name = "百度翻译ToolStripMenuItem";
            this.百度翻译ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.百度翻译ToolStripMenuItem.Text = "百度翻译";
            // 
            // EngLabel
            // 
            this.EngLabel.AutoSize = true;
            this.EngLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EngLabel.Location = new System.Drawing.Point(59, 68);
            this.EngLabel.Name = "EngLabel";
            this.EngLabel.Size = new System.Drawing.Size(90, 21);
            this.EngLabel.TabIndex = 1;
            this.EngLabel.Text = "英文字段名";
            // 
            // ChsLabel
            // 
            this.ChsLabel.AutoSize = true;
            this.ChsLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChsLabel.Location = new System.Drawing.Point(204, 68);
            this.ChsLabel.Name = "ChsLabel";
            this.ChsLabel.Size = new System.Drawing.Size(90, 21);
            this.ChsLabel.TabIndex = 2;
            this.ChsLabel.Text = "中文字段名";
            // 
            // EngTextBox
            // 
            this.EngTextBox.Location = new System.Drawing.Point(63, 106);
            this.EngTextBox.Name = "EngTextBox";
            this.EngTextBox.Size = new System.Drawing.Size(100, 21);
            this.EngTextBox.TabIndex = 3;
            // 
            // ChsTextBox
            // 
            this.ChsTextBox.Location = new System.Drawing.Point(208, 106);
            this.ChsTextBox.Name = "ChsTextBox";
            this.ChsTextBox.Size = new System.Drawing.Size(100, 21);
            this.ChsTextBox.TabIndex = 4;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(146, 162);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(247, 198);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 6;
            this.ExportButton.Text = "导出表结构";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 251);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ChsTextBox);
            this.Controls.Add(this.EngTextBox);
            this.Controls.Add(this.ChsLabel);
            this.Controls.Add(this.EngLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基本设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DBSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 百度翻译ToolStripMenuItem;
        private System.Windows.Forms.Label EngLabel;
        private System.Windows.Forms.Label ChsLabel;
        private System.Windows.Forms.TextBox EngTextBox;
        private System.Windows.Forms.TextBox ChsTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button ExportButton;
    }
}