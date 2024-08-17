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

namespace WizClicker
{
    public partial class InformationsForm : Form
    {
        public InformationsForm()
        {
            InitializeComponent();
        }

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

        private void ToolsBar_Close_InfForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ToolsBar_Close_InfForm_MouseEnter(object sender, EventArgs e)
        {
            ToolsBar_Close_InfForm.BackgroundImage = WizClicker.Properties.Resources.Main_close_hover;
        }
        private void ToolsBar_Close_InfForm_MouseLeave(object sender, EventArgs e)
        {
            ToolsBar_Close_InfForm.BackgroundImage = WizClicker.Properties.Resources.Main_close;
        }
        #endregion
    }
}
