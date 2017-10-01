using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePainter
{
    public partial class MainForm : Form
    {
        AcercaDeForm InfoForm;

        public MainForm()
        {
            
            InitializeComponent();

            this.Width = 800;
            this.Height = 600;
            lblMachineName.Text = Environment.MachineName;
        }

        private void flowFormat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picboxColorAzul_MouseEnter(object sender, EventArgs e)
        {
            ControlPaint.DrawFocusRectangle(Graphics.FromHwnd(picboxColorAzul.Handle), picboxColorAzul.ClientRectangle);
        }

        private void picboxColorVerde_MouseEnter(object sender, EventArgs e)
        {
            ControlPaint.DrawFocusRectangle(Graphics.FromHwnd(picboxColorVerde.Handle), picboxColorVerde.ClientRectangle);
        }

        private void picboxColorRojo_MouseEnter(object sender, EventArgs e)
        {
            ControlPaint.DrawFocusRectangle(Graphics.FromHwnd(picboxColorRojo.Handle), picboxColorRojo.ClientRectangle);
        }

        private void picboxColorNaranja_MouseEnter(object sender, EventArgs e)
        {
            ControlPaint.DrawFocusRectangle(Graphics.FromHwnd(picboxColorNaranja.Handle), picboxColorNaranja.ClientRectangle);
        }

        private void picboxColorRosa_MouseEnter(object sender, EventArgs e)
        {
            ControlPaint.DrawFocusRectangle(Graphics.FromHwnd(picboxColorRosa.Handle), picboxColorRosa.ClientRectangle);
        }

        private void picboxColorNegro_MouseEnter(object sender, EventArgs e)
        {
            ControlPaint.DrawFocusRectangle(Graphics.FromHwnd(picboxColorNegro.Handle), picboxColorNegro.ClientRectangle);
        }

        private void picboxColorAzul_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void picboxColorVerde_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picboxColorRojo_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picboxColorNaranja_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picboxColorRosa_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picboxColorNegro_MouseLeave(object sender, EventArgs e)
        {

        }

        private void metroTrackBarOpacidad_Scroll(object sender, ScrollEventArgs e)
        {
            numOpacidad.Value = decimal.Parse(metroTrackBarOpacidad.Value.ToString());
        }

        private void numOpacidad_Scroll(object sender, ScrollEventArgs e)
        {
            metroTrackBarOpacidad.Value = int.Parse(numOpacidad.Value.ToString());
        }

        private void numOpacidad_ValueChanged(object sender, EventArgs e)
        {
            metroTrackBarOpacidad.Value = int.Parse(numOpacidad.Value.ToString());
        }

        private void acercaDeHomePainterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InfoForm == null)
                InfoForm = new AcercaDeForm();

            InfoForm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
