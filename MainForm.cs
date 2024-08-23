using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using WindowsInput;

namespace WizClicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            userKeybindsList.Items.AddRange(new object[] { Key.F1, Key.F2, Key.F3, Key.F4, Key.F5, Key.F6, Key.F7, Key.F8, Key.F9, Key.F10, Key.F12, Key.A, Key.B, Key.C, Key.D, Key.E, Key.R, Key.Multiply, Key.Add, Key.Subtract, Key.OemComma, Key.OemPeriod, Key.OemPlus });
            keybinds_InfoToolTip.SetToolTip(userKeybindsList,
                "OemCommand = Virgule" +
                Environment.NewLine +
                "OemPeriod = Point virgule" +
                Environment.NewLine +
                "OemPlus = Egal");
        }
        Key confirmed_key;
        int confirmed_cps;
        bool key_press_tm_CanStart = false;

        private Thread clickThread;
        bool clicking = false;

        #region TOOLS BAR
        //CUSTOM TOOLS BAR ---------

        private bool dragging = false;
        private Point dragStartPoint;

        private void Custom_ToolsBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Capture la position du curseur par rapport à la barre d'outils
                dragging = true;
                dragStartPoint = e.Location;
            }
        }
        private void Custom_ToolsBar_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Stop dragging
                dragging = false;
            }
        }
        private void Custom_ToolsBar_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dragging)
            {
                // Calcul du décalage en pixels
                int offsetX = e.X - dragStartPoint.X;
                int offsetY = e.Y - dragStartPoint.Y;
                // Mise à jour de la position du formulaire
                this.Left += offsetX;
                this.Top += offsetY;
            }
        }

        //----

        private void ToolsBar_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void ToolsBar_Close_MouseEnter(object sender, EventArgs e)
        {
            ToolsBar_Close.BackgroundImage = WizClicker.Properties.Resources.Main_close_hover;
        }
        private void ToolsBar_Close_MouseLeave(object sender, EventArgs e)
        {
            ToolsBar_Close.BackgroundImage = WizClicker.Properties.Resources.Main_close;
        }

        //---

        private void ToolsBar_Reduce_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void ToolsBar_Reduce_MouseEnter(object sender, EventArgs e)
        {
            ToolsBar_Reduce.BackgroundImage = WizClicker.Properties.Resources.Main_reduce_hover;
        }
        private void ToolsBar_Reduce_MouseLeave(object sender, EventArgs e)
        {
            ToolsBar_Reduce.BackgroundImage = WizClicker.Properties.Resources.Main_reduce;
        }

        //---

        private void ToolsBar_Informations_Click(object sender, EventArgs e)
        {
            Form InformationsForm = new InformationsForm();
            InformationsForm.Show();
        }
        private void ToolsBar_Informations_MouseEnter(object sender, EventArgs e)
        {
            ToolsBar_Informations.BackgroundImage = WizClicker.Properties.Resources.Main_informations_hover;
        }
        private void ToolsBar_Informations_MouseLeave(object sender, EventArgs e)
        {
            ToolsBar_Informations.BackgroundImage = WizClicker.Properties.Resources.Main_informations;
        }
        //END TOOLS BAR ---------
        #endregion

        private void MainForm_Load(object sender, EventArgs e) //START KEY FINDER TIMER
        {
            Config.AppConfig configExtracted = Config.Extract(userKeybindsList, (int)cps.Maximum);

                userKeybindsList.SelectedIndex = userKeybindsList.Items.IndexOf(configExtracted.SavedKey);
                cps.Value = configExtracted.SavedCps;
                confirmed_key = configExtracted.SavedKey;
                confirmed_cps = (int)Math.Ceiling(1000.0 / (int)configExtracted.SavedCps);
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (userKeybindsList != null && (int)cps.Value > 0)
            {
                confirmed_key = (Key)userKeybindsList.SelectedItem;
                confirmed_cps = (int)Math.Ceiling(1000.0 / (int)cps.Value);
                confirmed_text.Text = "Saisie enregistrée"; confirmed_text.ForeColor = Color.FromArgb(0, 200, 50);
                key_press_tm_CanStart = false;

                Config.Update(confirmed_key, (int)cps.Value, false);
            }
            else { confirmed_text.Text = "Saisie incorrecte, réessayer"; confirmed_text.ForeColor = Color.FromArgb(200, 50, 0); }
        }

        //KEY FINDER TIMER

        private void key_finder_tm_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyToggled(confirmed_key))
            {
                if (!clicking && key_press_tm_CanStart == true)
                {
                    clicking = true;
                    state_text.Text = "WizClicker activé";
                    state_text.ForeColor = Color.FromArgb(255, 90, 0);
                    clickThread = new Thread(ClickLoop);
                    clickThread.Start();
                }
            }
            else
            {
                key_press_tm_CanStart = true;
                if (clicking)
                {
                    clicking = false;
                    state_text.Text = "WizClicker en attente";
                    state_text.ForeColor = Color.FromArgb(255, 200, 0);
                    clickThread.Join();
                }
            }
        }

        private void ClickLoop()
        {
            while (clicking)
            {
                leftclick();
                Thread.Sleep(confirmed_cps);
            }
        }

        public void leftclick()
        {
            var sim = new InputSimulator();
            sim.Mouse.LeftButtonClick();
        }

        public int getMaxCps() { return (int)cps.Maximum; }
        public System.Windows.Forms.ComboBox keylistComboBox() { return userKeybindsList; }
    }
}