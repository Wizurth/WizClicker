﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace WizClicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            userKeybindsList.Items.AddRange(new object[] {Key.F1, Key.F2, Key.F3, Key.F4, Key.F5, Key.F6, Key.F7, Key.F8, Key.F9, Key.F10, Key.F12, Key.A, Key.B, Key.C, Key.D, Key.E, Key.R, Key.Multiply, Key.Add, Key.Subtract, Key.OemComma, Key.OemPeriod, Key.OemPlus});
            keybinds_InfoToolTip.SetToolTip(userKeybindsList,
                "OemCommand = Virgule" +
                Environment.NewLine +
                "OemPeriod = Point virgule" +
                Environment.NewLine +
                "OemPlus = Egal");
        }
        Key confirmed_key;
        int confirmed_cps = 1;
        bool key_press_tm_CanStart = false;


        #region TOOLS BAR
        //CUSTOM TOOLS BAR ---------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void Custom_ToolsBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

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
            key_press_tm.Interval = 100;
            key_press_tm.Start();

            Config.AppConfig configExtracted = Config.Extract();
            if (configExtracted != null)
            {
                userKeybindsList.SelectedIndex = userKeybindsList.Items.IndexOf(configExtracted.SavedKey);
                cps.Value = configExtracted.SavedCps;
                confirmed_key = configExtracted.SavedKey;
                confirmed_cps = (int)Math.Ceiling(1000.0 / (int)configExtracted.SavedCps);
            }
            else
            {
                userKeybindsList.SelectedIndex = 0;
                //CPS Min value
            }
        }
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (userKeybindsList != null && (int)cps.Value > 0)
            {
                confirmed_key = (Key)userKeybindsList.SelectedItem;
                confirmed_cps = (int)Math.Ceiling(1000.0 / (int)cps.Value);
                confirmed_text.Text = "Saisie enregistrée"; confirmed_text.ForeColor = Color.FromArgb(0, 200, 50);
                key_press_tm_CanStart = false;

                Config.Update(confirmed_key, (int)cps.Value);
            }
            else { confirmed_text.Text = "Saisie incorrecte, réessayer"; confirmed_text.ForeColor = Color.FromArgb(200, 50, 0); } //ERREUR
        }

        //IMPORT

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwdata, int dwextrainfo);
        public enum mouseeventflags
        {
            LeftDown = 2,
            LeftUp = 4,
        }
        public void leftclick(Point p)
        {
            mouse_event((int)(mouseeventflags.LeftDown), p.X, p.Y, 0, 0);
            mouse_event((int)(mouseeventflags.LeftUp), p.X, p.Y, 0, 0);
        }

        //TIMERS

        private void key_finder_tm_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyToggled(confirmed_key))
            {
                if (key_press_tm_CanStart == true)
                {
                    key_press_tm.Start();
                    state_text.Text = "WizClicker activé";
                    state_text.ForeColor = Color.FromArgb(255, 90, 0);
                }
            }

            if (!Keyboard.IsKeyToggled(confirmed_key))
            {
                key_press_tm.Stop();
                state_text.Text = "WizClicker en attente";
                state_text.ForeColor = Color.FromArgb(255, 200, 0);
                key_press_tm_CanStart = true;
            }
        }
        private void key_press_tm_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }
    }
}