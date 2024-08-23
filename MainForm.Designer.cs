namespace WizClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cps = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.userKeybindsList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.key_finder_tm = new System.Windows.Forms.Timer(this.components);
            this.confirm_btn = new System.Windows.Forms.Button();
            this.confirmed_text = new System.Windows.Forms.Label();
            this.text_panel = new System.Windows.Forms.Panel();
            this.state_text = new System.Windows.Forms.Label();
            this.keybinds_InfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ToolsBar_Close = new System.Windows.Forms.Button();
            this.ToolsBar_Informations = new System.Windows.Forms.Button();
            this.ToolsBar_Reduce = new System.Windows.Forms.Button();
            this.Custom_ToolsBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cps)).BeginInit();
            this.text_panel.SuspendLayout();
            this.Custom_ToolsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cps
            // 
            this.cps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cps.Location = new System.Drawing.Point(153, 160);
            this.cps.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.cps.Name = "cps";
            this.cps.Size = new System.Drawing.Size(100, 20);
            this.cps.TabIndex = 2;
            this.cps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPS";
            // 
            // userKeybindsList
            // 
            this.userKeybindsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userKeybindsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userKeybindsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userKeybindsList.FormattingEnabled = true;
            this.userKeybindsList.Location = new System.Drawing.Point(150, 240);
            this.userKeybindsList.Name = "userKeybindsList";
            this.userKeybindsList.Size = new System.Drawing.Size(100, 21);
            this.userKeybindsList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(125, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Touche d\'activation";
            // 
            // key_finder_tm
            // 
            this.key_finder_tm.Enabled = true;
            this.key_finder_tm.Tick += new System.EventHandler(this.key_finder_tm_Tick);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_btn.BackColor = System.Drawing.Color.Transparent;
            this.confirm_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.confirm_btn.FlatAppearance.BorderSize = 0;
            this.confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(75, 350);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(241, 30);
            this.confirm_btn.TabIndex = 3;
            this.confirm_btn.Text = "Confirmer";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // confirmed_text
            // 
            this.confirmed_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmed_text.BackColor = System.Drawing.Color.Transparent;
            this.confirmed_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmed_text.Location = new System.Drawing.Point(0, 45);
            this.confirmed_text.Name = "confirmed_text";
            this.confirmed_text.Size = new System.Drawing.Size(400, 25);
            this.confirmed_text.TabIndex = 5;
            this.confirmed_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_panel
            // 
            this.text_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_panel.BackColor = System.Drawing.Color.Transparent;
            this.text_panel.Controls.Add(this.state_text);
            this.text_panel.Controls.Add(this.confirmed_text);
            this.text_panel.Location = new System.Drawing.Point(0, 280);
            this.text_panel.Name = "text_panel";
            this.text_panel.Size = new System.Drawing.Size(400, 70);
            this.text_panel.TabIndex = 6;
            // 
            // state_text
            // 
            this.state_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.state_text.BackColor = System.Drawing.Color.Transparent;
            this.state_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.state_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_text.Location = new System.Drawing.Point(0, 0);
            this.state_text.Name = "state_text";
            this.state_text.Size = new System.Drawing.Size(400, 30);
            this.state_text.TabIndex = 6;
            this.state_text.Text = "default_text";
            this.state_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keybinds_InfoToolTip
            // 
            this.keybinds_InfoToolTip.AutomaticDelay = 300;
            this.keybinds_InfoToolTip.AutoPopDelay = 1000000;
            this.keybinds_InfoToolTip.InitialDelay = 300;
            this.keybinds_InfoToolTip.ReshowDelay = 60;
            this.keybinds_InfoToolTip.ToolTipTitle = "Informations touches :";
            // 
            // ToolsBar_Close
            // 
            this.ToolsBar_Close.BackColor = System.Drawing.Color.Transparent;
            this.ToolsBar_Close.BackgroundImage = global::WizClicker.Properties.Resources.Main_close;
            this.ToolsBar_Close.FlatAppearance.BorderSize = 0;
            this.ToolsBar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsBar_Close.ForeColor = System.Drawing.Color.Transparent;
            this.ToolsBar_Close.Location = new System.Drawing.Point(344, 2);
            this.ToolsBar_Close.Name = "ToolsBar_Close";
            this.ToolsBar_Close.Size = new System.Drawing.Size(49, 27);
            this.ToolsBar_Close.TabIndex = 7;
            this.ToolsBar_Close.UseVisualStyleBackColor = false;
            this.ToolsBar_Close.Click += new System.EventHandler(this.ToolsBar_Close_Click);
            this.ToolsBar_Close.MouseEnter += new System.EventHandler(this.ToolsBar_Close_MouseEnter);
            this.ToolsBar_Close.MouseLeave += new System.EventHandler(this.ToolsBar_Close_MouseLeave);
            // 
            // ToolsBar_Informations
            // 
            this.ToolsBar_Informations.BackColor = System.Drawing.Color.Transparent;
            this.ToolsBar_Informations.BackgroundImage = global::WizClicker.Properties.Resources.Main_informations;
            this.ToolsBar_Informations.FlatAppearance.BorderSize = 0;
            this.ToolsBar_Informations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsBar_Informations.Location = new System.Drawing.Point(282, 2);
            this.ToolsBar_Informations.Name = "ToolsBar_Informations";
            this.ToolsBar_Informations.Size = new System.Drawing.Size(34, 27);
            this.ToolsBar_Informations.TabIndex = 8;
            this.ToolsBar_Informations.UseVisualStyleBackColor = false;
            this.ToolsBar_Informations.Click += new System.EventHandler(this.ToolsBar_Informations_Click);
            this.ToolsBar_Informations.MouseEnter += new System.EventHandler(this.ToolsBar_Informations_MouseEnter);
            this.ToolsBar_Informations.MouseLeave += new System.EventHandler(this.ToolsBar_Informations_MouseLeave);
            // 
            // ToolsBar_Reduce
            // 
            this.ToolsBar_Reduce.BackColor = System.Drawing.Color.Transparent;
            this.ToolsBar_Reduce.BackgroundImage = global::WizClicker.Properties.Resources.Main_reduce;
            this.ToolsBar_Reduce.FlatAppearance.BorderSize = 0;
            this.ToolsBar_Reduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsBar_Reduce.Location = new System.Drawing.Point(313, 2);
            this.ToolsBar_Reduce.Name = "ToolsBar_Reduce";
            this.ToolsBar_Reduce.Size = new System.Drawing.Size(34, 27);
            this.ToolsBar_Reduce.TabIndex = 9;
            this.ToolsBar_Reduce.UseVisualStyleBackColor = false;
            this.ToolsBar_Reduce.Click += new System.EventHandler(this.ToolsBar_Reduce_Click);
            this.ToolsBar_Reduce.MouseEnter += new System.EventHandler(this.ToolsBar_Reduce_MouseEnter);
            this.ToolsBar_Reduce.MouseLeave += new System.EventHandler(this.ToolsBar_Reduce_MouseLeave);
            // 
            // Custom_ToolsBar
            // 
            this.Custom_ToolsBar.BackColor = System.Drawing.Color.Transparent;
            this.Custom_ToolsBar.Controls.Add(this.button1);
            this.Custom_ToolsBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Custom_ToolsBar.Location = new System.Drawing.Point(0, 0);
            this.Custom_ToolsBar.Name = "Custom_ToolsBar";
            this.Custom_ToolsBar.Size = new System.Drawing.Size(400, 38);
            this.Custom_ToolsBar.TabIndex = 11;
            this.Custom_ToolsBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Custom_ToolsBar_MouseDown);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(344, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 27);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::WizClicker.Properties.Resources.Main;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.ControlBox = false;
            this.Controls.Add(this.ToolsBar_Reduce);
            this.Controls.Add(this.ToolsBar_Close);
            this.Controls.Add(this.ToolsBar_Informations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cps);
            this.Controls.Add(this.userKeybindsList);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.text_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Custom_ToolsBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WizClicker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cps)).EndInit();
            this.text_panel.ResumeLayout(false);
            this.Custom_ToolsBar.ResumeLayout(false);
            this.Custom_ToolsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown cps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userKeybindsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer key_finder_tm;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Label confirmed_text;
        private System.Windows.Forms.Panel text_panel;
        private System.Windows.Forms.Label state_text;
        private System.Windows.Forms.ToolTip keybinds_InfoToolTip;
        private System.Windows.Forms.Button ToolsBar_Close;
        private System.Windows.Forms.Button ToolsBar_Informations;
        private System.Windows.Forms.Button ToolsBar_Reduce;
        private System.Windows.Forms.Panel Custom_ToolsBar;
        private System.Windows.Forms.Button button1;
    }
}

