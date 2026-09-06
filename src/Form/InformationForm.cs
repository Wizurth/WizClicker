using System;
using System.Drawing;
using System.Windows.Forms;

namespace WizClicker
{

//#############################################################################
//##--------------------------------- CLASS ---------------------------------##
//#############################################################################

public partial class InformationForm : Form
{
    public InformationForm()
    {
        InitializeComponent();
    }

//#############################################################################
//##--------------------------------- FIELDS --------------------------------##
//#############################################################################

    private bool bIsDragging = false;
    private Point DragStartPoint;

//#############################################################################
//##-------------------------------- METHODS --------------------------------##
//#############################################################################

#region ToolsBar
    private void Custom_ToolsBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            // Capture la position du curseur par rapport à la barre d'outils
            bIsDragging = true;
            DragStartPoint = e.Location;
        }
    }

    private void Custom_ToolsBar_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            // Stop dragging
            bIsDragging = false;
        }
    }

    private void Custom_ToolsBar_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
    {
        if (bIsDragging)
        {
            // Calcul du décalage en pixels
            int offsetX = e.X - DragStartPoint.X;
            int offsetY = e.Y - DragStartPoint.Y;
            // Mise à jour de la position du formulaire
            this.Left += offsetX;
            this.Top += offsetY;
        }
    }

    private void ToolsBar_Close_InfForm_Click(object sender, EventArgs e)
        => this.Close();

    private void ToolsBar_Close_InfForm_MouseEnter(object sender, EventArgs e)
        => ToolsBar_Close_InfForm.BackgroundImage = WizClicker.Properties.Resources.Main_close_hover;

    private void ToolsBar_Close_InfForm_MouseLeave(object sender, EventArgs e)
        => ToolsBar_Close_InfForm.BackgroundImage = WizClicker.Properties.Resources.Main_close;
#endregion
}
}