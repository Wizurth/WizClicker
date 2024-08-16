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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.confirm_btn = new System.Windows.Forms.Button();
            this.confirmed_text = new System.Windows.Forms.Label();
            this.text_label = new System.Windows.Forms.Panel();
            this.debug_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cps)).BeginInit();
            this.text_label.SuspendLayout();
            this.SuspendLayout();
            // 
            // cps
            // 
            this.cps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cps.Location = new System.Drawing.Point(65, 110);
            this.cps.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cps.Name = "cps";
            this.cps.Size = new System.Drawing.Size(93, 20);
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
            this.label1.Location = new System.Drawing.Point(95, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPS";
            // 
            // userKeybindsList
            // 
            this.userKeybindsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userKeybindsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userKeybindsList.FormattingEnabled = true;
            this.userKeybindsList.Location = new System.Drawing.Point(50, 50);
            this.userKeybindsList.Name = "userKeybindsList";
            this.userKeybindsList.Size = new System.Drawing.Size(120, 21);
            this.userKeybindsList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(60, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Touche d\'activation";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(75, 190);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(75, 23);
            this.confirm_btn.TabIndex = 3;
            this.confirm_btn.Text = "Confirmer";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // confirmed_text
            // 
            this.confirmed_text.BackColor = System.Drawing.Color.Transparent;
            this.confirmed_text.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.confirmed_text.Location = new System.Drawing.Point(0, 5);
            this.confirmed_text.Name = "confirmed_text";
            this.confirmed_text.Size = new System.Drawing.Size(230, 13);
            this.confirmed_text.TabIndex = 5;
            this.confirmed_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_label
            // 
            this.text_label.Controls.Add(this.confirmed_text);
            this.text_label.Location = new System.Drawing.Point(0, 166);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(230, 18);
            this.text_label.TabIndex = 6;
            // 
            // debug_txt
            // 
            this.debug_txt.AutoSize = true;
            this.debug_txt.Location = new System.Drawing.Point(38, 13);
            this.debug_txt.Name = "debug_txt";
            this.debug_txt.Size = new System.Drawing.Size(14, 13);
            this.debug_txt.TabIndex = 7;
            this.debug_txt.Text = "#";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(234, 236);
            this.ControlBox = false;
            this.Controls.Add(this.debug_txt);
            this.Controls.Add(this.text_label);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userKeybindsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WizClicker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cps)).EndInit();
            this.text_label.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown cps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userKeybindsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Label confirmed_text;
        private System.Windows.Forms.Panel text_label;
        private System.Windows.Forms.Label debug_txt;
    }
}

