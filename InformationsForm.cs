using System;
using System.Drawing;
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
