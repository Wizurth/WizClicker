namespace WizClicker
{
    partial class InformationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationsForm));
            this.Custom_ToolsBar = new System.Windows.Forms.Panel();
            this.ToolsBar_Close_InfForm = new System.Windows.Forms.Button();
            this.ToolsBar_Close = new System.Windows.Forms.Button();
            this.Custom_ToolsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Custom_ToolsBar
            // 
            this.Custom_ToolsBar.BackColor = System.Drawing.Color.Transparent;
            this.Custom_ToolsBar.Controls.Add(this.ToolsBar_Close_InfForm);
            this.Custom_ToolsBar.Controls.Add(this.ToolsBar_Close);
            this.Custom_ToolsBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Custom_ToolsBar.Location = new System.Drawing.Point(0, 0);
            this.Custom_ToolsBar.Name = "Custom_ToolsBar";
            this.Custom_ToolsBar.Size = new System.Drawing.Size(400, 38);
            this.Custom_ToolsBar.TabIndex = 2;
            this.Custom_ToolsBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Custom_ToolsBar_MouseDown);
            this.Custom_ToolsBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Custom_ToolsBar_MouseMove);
            this.Custom_ToolsBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Custom_ToolsBar_MouseUp);
            // 
            // ToolsBar_Close_InfForm
            // 
            this.ToolsBar_Close_InfForm.AutoSize = true;
            this.ToolsBar_Close_InfForm.BackgroundImage = global::WizClicker.Properties.Resources.Main_close;
            this.ToolsBar_Close_InfForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolsBar_Close_InfForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.ToolsBar_Close_InfForm.FlatAppearance.BorderSize = 0;
            this.ToolsBar_Close_InfForm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ToolsBar_Close_InfForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ToolsBar_Close_InfForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsBar_Close_InfForm.Location = new System.Drawing.Point(344, 2);
            this.ToolsBar_Close_InfForm.Name = "ToolsBar_Close_InfForm";
            this.ToolsBar_Close_InfForm.Size = new System.Drawing.Size(49, 27);
            this.ToolsBar_Close_InfForm.TabIndex = 3;
            this.ToolsBar_Close_InfForm.UseVisualStyleBackColor = true;
            this.ToolsBar_Close_InfForm.Click += new System.EventHandler(this.ToolsBar_Close_InfForm_Click);
            this.ToolsBar_Close_InfForm.MouseEnter += new System.EventHandler(this.ToolsBar_Close_InfForm_MouseEnter);
            this.ToolsBar_Close_InfForm.MouseLeave += new System.EventHandler(this.ToolsBar_Close_InfForm_MouseLeave);
            // 
            // ToolsBar_Close
            // 
            this.ToolsBar_Close.AutoSize = true;
            this.ToolsBar_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolsBar_Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.ToolsBar_Close.FlatAppearance.BorderSize = 0;
            this.ToolsBar_Close.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ToolsBar_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ToolsBar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsBar_Close.Location = new System.Drawing.Point(344, 2);
            this.ToolsBar_Close.Name = "ToolsBar_Close";
            this.ToolsBar_Close.Size = new System.Drawing.Size(49, 27);
            this.ToolsBar_Close.TabIndex = 0;
            this.ToolsBar_Close.UseVisualStyleBackColor = true;
            // 
            // InformationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WizClicker.Properties.Resources.Infos;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.Custom_ToolsBar);
            this.Cursor = System.Windows.Forms.Cursors.Help;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformationsForm";
            this.Text = "InformationsForm";
            this.Custom_ToolsBar.ResumeLayout(false);
            this.Custom_ToolsBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Custom_ToolsBar;
        private System.Windows.Forms.Button ToolsBar_Close_InfForm;
        private System.Windows.Forms.Button ToolsBar_Close;
    }
}