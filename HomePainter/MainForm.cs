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
        Figura miFigura = new Figura(100, 100, new Size(100, 100), Brushes.DodgerBlue, Color.Black, 1);

        PictureBox picture = new PictureBox();
            
        bool blEsRectangulo = true;
        bool blEsCirculo = false;
        bool blEsEllipse = false;
        bool blEsPoligono = false;

        
        public MainForm()
        {
            
            InitializeComponent();

            this.Width = 1200;
            this.Height = 600;
            lblMachineName.Text = Environment.MachineName;

            // Se instancia la figura y se nombra.
            miFigura.Nombre = "Shape1";
            miFigura.TipoFigura = "Rectangulo";

            // Se actualiza los controles para los colores del borde.
            colorBorde = miFigura.BordeColor;
            picboxBordeColor.BackColor = colorBorde;

            // Se actualiza los puntos de grosor en el control de la forma.
            numBordeGrosor.Value = (decimal)miFigura.BordeGrosor;
            
            // Se actualiza los valores de los controles para el tamano.
            numWidth.Value = (decimal)miFigura.Tamano.Width;
            numHeight.Value = (decimal)miFigura.Tamano.Height;

            // Se actualiza los valores de los controles para la posicion del picturebox.
            numX.Value = (decimal)miFigura.PosicionX;
            numY.Value = (decimal)miFigura.PosicionY;

            // Se actualiza los valores para la rotacion de la figura.

            // Se actualiza los controles si tiene grosor o no la figura.
            if (miFigura.BordeGrosor > 0)
            {
                cboBorde.Text = "Linea";
                //grpboxBorde.Size = new Size(320, 100);
                //picboxBordeColor.Visible = true;
                //numBordeGrosor.Visible = true;
            }
            else
            {
                cboBorde.Text = "Sin Bordes";
                //grpboxBorde.Size = new Size(320, 50);
                //picboxBordeColor.Visible = false;
                //numBordeGrosor.Visible = false;
            }

            this.picture.Name = miFigura.Nombre;
            this.picture.Location = new Point(miFigura.PosicionX, miFigura.PosicionY);
            this.picture.Size = new Size(miFigura.Tamano.Width + (miFigura.Tamano.Width / 5), miFigura.Tamano.Height + (miFigura.Tamano.Height / 5));

            this.picture.BorderStyle = BorderStyle.FixedSingle;

            //g.FillRectangle(brushRelleno, new Rectangle(new Point(10, 10), new Size(100, 100)));

            //g.DrawRectangle(new Pen(colorBorde, (float)numBordeGrosor.Value), new Rectangle(new Point(10, 10), new Size(100, 100)));

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
                numX.Value = (decimal)(picture.Location.X + e.X - dragPoint.X);
                numY.Value = (decimal)(picture.Location.Y + e.Y - dragPoint.Y);
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

                // Actualizar el tamano de la figura y despues el picturebox
                miFigura.Tamano = new Size((int)numWidth.Value, (int)numHeight.Value);
                this.picture.Size = new Size(miFigura.Tamano.Width + (miFigura.Tamano.Width / 5), miFigura.Tamano.Height + (miFigura.Tamano.Height / 5));

                //this.picture.Width = (int)numWidth.Value;
                //this.picture.Height = (int)numHeight.Value;

                this.picture.BorderStyle = BorderStyle.FixedSingle;

                g = this.picture.CreateGraphics();

                g.Clear(Color.White);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                //new SolidBrush(Color.FromArgb(colorBorde.A, colorBorde.R, colorBorde.G, colorBorde.B));

                
                
                switch(miFigura.TipoFigura)
                {
                    case "Rectangulo":

                        g.FillRectangle(brushRelleno, new Rectangle(new Point(10, 10), miFigura.Tamano));
                        if (miFigura.BordeGrosor > 0)
                            g.DrawRectangle(new Pen(colorBorde, (float)numBordeGrosor.Value), new Rectangle(new Point(10, 10), miFigura.Tamano));

                        break;


                    case "Elipse":

                        g.FillEllipse(brushRelleno, new Rectangle(new Point(10, 10), miFigura.Tamano));
                        if (miFigura.BordeGrosor > 0)
                            g.DrawEllipse(new Pen(colorBorde, (float)numBordeGrosor.Value), new Rectangle(new Point(10, 10), miFigura.Tamano));
                        break;

                    case "Poligono":



                        break;
                }
                

            }
        }

        private void MetroMainPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            //this.picture.Size = new Size(123, 123);
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void picboxMain_MouseEnter(object sender, EventArgs e)
        //{
        //}

        private void cboBorde_TextChanged(object sender, EventArgs e)
        {
            if (cboBorde.Text == "Linea")
            {
                miFigura.BordeGrosor = 1;
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
            miFigura.BordeColor = colorBorde;
            picboxBordeColor.BackColor = colorBorde;
        }

        private void metroMainPanel_MouseEnter(object sender, EventArgs e)
        {
            miFigura.BordeColor = colorBorde;
            picboxBordeColor.BackColor = colorBorde;
        }

        private void metroTabControlFormato_MouseEnter(object sender, EventArgs e)
        {
            miFigura.BordeColor = colorBorde;
            picboxBordeColor.BackColor = colorBorde;
        }

        private void menuStripMain_MouseEnter(object sender, EventArgs e)
        {
            miFigura.BordeColor = colorBorde;
            picboxBordeColor.BackColor = colorBorde;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //Graphics g = this.picture.CreateGraphics();
            //g.Clear(Color.White);
            //g.FillRectangle(Brushes.Red, new Rectangle(new Point(20, 20), new Size(100, 100)));
            //g.DrawRectangle(new Pen(colorBorde, (float)numBordeGrosor.Value), new Rectangle(new Point(20, 20), new Size(100, 100)));
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

        #region AcercaDeToolStripMenuItem_Click

        private void acercaDeHomePainterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InfoForm.IsDisposed)
                InfoForm = new AcercaDeForm();

            InfoForm.Show();
        }

        #endregion

        #region FigurasToolStripMenuItem_Click

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miFigura.TipoFigura = "Rectangulo";
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miFigura.TipoFigura = "Circulo";
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miFigura.TipoFigura = "Elipse";
        }

        private void poligonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miFigura.TipoFigura = "Poligono";
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
            miFigura.Tamano = new Size((int)numWidth.Value, miFigura.Tamano.Height);
            this.picture.Size = new Size(miFigura.Tamano.Width + (miFigura.Tamano.Width / 5), miFigura.Tamano.Height + (miFigura.Tamano.Height / 5));
        }

        private void numHeight_ValueChanged(object sender, EventArgs e)
        {
            miFigura.Tamano = new Size(miFigura.Tamano.Width, (int)numHeight.Value);
            this.picture.Size = new Size(miFigura.Tamano.Width + (miFigura.Tamano.Width / 5), miFigura.Tamano.Height + (miFigura.Tamano.Height / 5));
        }

        private void numX_ValueChanged(object sender, EventArgs e)
        {
            miFigura.PosicionX = (int)numX.Value;
            this.picture.Location = new Point(miFigura.PosicionX, miFigura.PosicionY);
        }

        private void numY_ValueChanged(object sender, EventArgs e)
        {

            miFigura.PosicionY = (int)numY.Value;
            this.picture.Location = new Point(miFigura.PosicionX, miFigura.PosicionY);
        }

        private void numGrados_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numLados_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
