using System;
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
            userKeybindsList.Items.AddRange(new object[] { Key.F4, Key.Multiply, Key.Add, Key.Subtract });
            userKeybindsList.SelectedIndex = 0;
        }
        Key confirmed_key;
        int confirmed_cps = 1;
        bool timer1_CanStart;

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
        private void timer1_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(Keyboard.GetKeyStates(Key.F4));
            Console.WriteLine(timer1_CanStart);
            if (Keyboard.IsKeyToggled(confirmed_key))
            {
                if (timer1_CanStart == true)
                {
                    timer1.Start();
                }
            }

            if (!Keyboard.IsKeyToggled(confirmed_key))
            {
                timer1.Stop();
                timer1_CanStart = true;
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (userKeybindsList != null && cps.Value > 0)
            {
                confirmed_key = (Key)userKeybindsList.SelectedItem;
                confirmed_cps = 1000 / (int)cps.Value;
                confirmed_text.Text = "Saisie enregistrée"; confirmed_text.ForeColor = Color.FromArgb(0, 200, 50);
            }
            else { confirmed_text.Text = "Saisie incorrecte, réessayer"; confirmed_text.ForeColor = Color.FromArgb(200, 50, 0); } //ERREUR
        }
        private void MainForm_Load(object sender, EventArgs e) //START KEY FINDER TIMER
        {
            Console.WriteLine("ok");
            timer2.Interval = 100;
            timer2.Start();
            confirmed_key = (Key)userKeybindsList.SelectedItem;
        }
    }
}
