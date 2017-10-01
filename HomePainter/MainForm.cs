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

        #region Miembros Publicos Estaticos

        public static Color colorBorde;
        
        #endregion

        #region Forms

        AcercaDeForm InfoForm;
        ColoresForm coloresForm;

        #endregion

        PictureBox picture = new PictureBox
        {
            Name = "pictureBox",
            Size = new Size(100, 100),
            Location = new Point(100, 100)
        };
        
        public MainForm()
        {
            
            InitializeComponent();

            colorBorde = Color.Black;

            this.Width = 800;
            this.Height = 600;

            grpboxBorde.Size = new Size(320, 50);
            picboxBordeColor.Visible = false;
            numBordeGrosor.Visible = false;

            lblMachineName.Text = Environment.MachineName;

            this.picture.BorderStyle = BorderStyle.FixedSingle;

            this.picture.SizeChanged += Picture_SizeChanged;

            this.metroMainPanel.ControlAdded += MetroMainPanel_ControlAdded;

            this.metroMainPanel.Controls.Add(this.picture);

        }

        private void Picture_SizeChanged(object sender, EventArgs e)
        {
            Graphics g = this.picture.CreateGraphics();
            g.FillRectangle(Brushes.Red, new Rectangle(new Point(0, 0), new Size(100, 100)));
        }

        private void MetroMainPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            this.picture.Size = new Size(100, 100);
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



        private void picboxMain_MouseEnter(object sender, EventArgs e)
        {
            picboxBordeColor.BackColor = colorBorde;
        }

        private void cboBorde_TextChanged(object sender, EventArgs e)
        {
            if (cboBorde.Text == "Linea")
            {
                grpboxBorde.Size = new Size(320, 100);
                picboxBordeColor.Visible = true;
                numBordeGrosor.Visible = true;
            }
            else
            {
                grpboxBorde.Size = new Size(320, 50);
                picboxBordeColor.Visible = false;
                numBordeGrosor.Visible = false;
            }
        }

        private void picboxBordeColor_Click(object sender, EventArgs e)
        {
            if (coloresForm == null)
                coloresForm = new ColoresForm();

            coloresForm.Show();
        }
    }
}
