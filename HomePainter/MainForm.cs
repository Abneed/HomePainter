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

        AcercaDeForm InfoForm = new AcercaDeForm();
        ColoresForm coloresForm = new ColoresForm();

        #endregion

        Graphics g;
        Brush brushRelleno = Brushes.DodgerBlue;
        bool blEsRectangulo = true;
        bool blEsCirculo = false;
        bool blEsEllipse = false;
        bool blEsPoligono = false;

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

            this.Width = 1200;
            this.Height = 600;

            grpboxBorde.Size = new Size(320, 50);
            picboxBordeColor.Visible = false;
            numBordeGrosor.Visible = false;

            lblMachineName.Text = Environment.MachineName;

            this.picture.BorderStyle = BorderStyle.FixedSingle;

            
            ControlPaint.DrawFocusRectangle(Graphics.FromHwnd(picture.Handle), picture.ClientRectangle);

            this.picture.Click += Picture_Click;
            this.picture.MouseDown += Picture_MouseDown;
            this.picture.MouseMove += Picture_MouseMove;
            this.picture.MouseUp += Picture_MouseUp;
            this.picture.DoubleClick += Picture_DoubleClick;
            this.metroMainPanel.ControlAdded += MetroMainPanel_ControlAdded;

            this.metroMainPanel.Controls.Add(this.picture);
            
        }

        Point dragPoint = Point.Empty;
        bool blDragging = false;

        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            dragPoint = new Point(e.X, e.Y);
        }

        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (blDragging)
            {
                picture.Location = new Point(picture.Location.X + e.X - dragPoint.X, picture.Location.Y + e.Y - dragPoint.Y);
            }
        }

        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Picture_DoubleClick(object sender, EventArgs e)
        {
            blDragging = true;
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            if (blDragging)
            {
                blDragging = false;
 
                g = this.picture.CreateGraphics();
                g.Clear(Color.White);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                g.FillRectangle(brushRelleno, new Rectangle(new Point(10, 10), new Size(100, 100)));
                g.DrawRectangle(new Pen(colorBorde, (float)numBordeGrosor.Value), new Rectangle(new Point(10, 10), new Size(100, 100)));

            }
        }

        private void MetroMainPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            this.picture.Size = new Size(123, 123);
        }

        private void flowFormat_Paint(object sender, PaintEventArgs e)
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
            if (InfoForm.IsDisposed)
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

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            picboxBordeColor.BackColor = colorBorde;
        }

        private void metroMainPanel_MouseEnter(object sender, EventArgs e)
        {
            picboxBordeColor.BackColor = colorBorde;
        }

        private void metroTabControlFormato_MouseEnter(object sender, EventArgs e)
        {
            picboxBordeColor.BackColor = colorBorde;
        }

        private void menuStripMain_MouseEnter(object sender, EventArgs e)
        {
            picboxBordeColor.BackColor = colorBorde;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Graphics g = this.picture.CreateGraphics();
            g.Clear(Color.White);
            g.FillRectangle(Brushes.Red, new Rectangle(new Point(20, 20), new Size(100, 100)));
            g.DrawRectangle(new Pen(colorBorde, (float)numBordeGrosor.Value), new Rectangle(new Point(20, 20), new Size(100, 100)));
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            coloresForm.Hide();
        }

        private void metroMainPanel_Click(object sender, EventArgs e)
        {
            coloresForm.Hide();
        }

        private void metroTabControlFormato_Click(object sender, EventArgs e)
        {
            coloresForm.Hide();
        }

        private void menuStripMain_Click(object sender, EventArgs e)
        {
            coloresForm.Hide();
        }

        #region FigurasToolStripMenuItem_Click

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void poligonoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region picboxColors_Click

        private void picboxColorAzul_Click(object sender, EventArgs e)
        {
            brushRelleno = Brushes.DodgerBlue;
        }

        private void picboxColorVerde_Click(object sender, EventArgs e)
        {
            brushRelleno = Brushes.LimeGreen;
        }

        private void picboxColorRojo_Click(object sender, EventArgs e)
        {
            brushRelleno = Brushes.Red;
        }

        private void picboxColorNaranja_Click(object sender, EventArgs e)
        {
            brushRelleno = Brushes.Orange;
        }

        private void picboxColorRosa_Click(object sender, EventArgs e)
        {
            brushRelleno = Brushes.HotPink;
        }

        private void picboxColorNegro_Click(object sender, EventArgs e)
        {
            brushRelleno = Brushes.Black;
        }

        #endregion

        #region picboxColors_MouseEnter

        private void picboxColorAzul_MouseEnter(object sender, EventArgs e)
        {
            picboxColorAzul.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picboxColorVerde_MouseEnter(object sender, EventArgs e)
        {
            picboxColorVerde.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picboxColorRojo_MouseEnter(object sender, EventArgs e)
        {
            picboxColorRojo.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picboxColorNaranja_MouseEnter(object sender, EventArgs e)
        {
            picboxColorNaranja.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picboxColorRosa_MouseEnter(object sender, EventArgs e)
        {
            picboxColorRosa.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picboxColorNegro_MouseEnter(object sender, EventArgs e)
        {
            picboxColorNegro.BorderStyle = BorderStyle.FixedSingle;
        }

        #endregion
        
        #region picboxColors_MouseLeave

        private void picboxColorAzul_MouseLeave(object sender, EventArgs e)
        {
            picboxColorAzul.BorderStyle = BorderStyle.None;
        }

        private void picboxColorVerde_MouseLeave(object sender, EventArgs e)
        {
            picboxColorVerde.BorderStyle = BorderStyle.None;
        }

        private void picboxColorRojo_MouseLeave(object sender, EventArgs e)
        {
            picboxColorRojo.BorderStyle = BorderStyle.None;
        }

        private void picboxColorNaranja_MouseLeave(object sender, EventArgs e)
        {
            picboxColorNaranja.BorderStyle = BorderStyle.None;
        }

        private void picboxColorRosa_MouseLeave(object sender, EventArgs e)
        {
            picboxColorRosa.BorderStyle = BorderStyle.None;
        }

        private void picboxColorNegro_MouseLeave(object sender, EventArgs e)
        {
            picboxColorNegro.BorderStyle = BorderStyle.None;
        }


        #endregion

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numHeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numX_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numY_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numGrados_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numLados_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
