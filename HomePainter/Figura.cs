using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePainter
{
    class Figura
    {
        private string _strNombre;
        private string _strTipoFigura;
        private int _intPosicionX;
        private int _intPosicionY;
        private Size _sizeTamano;
        private int _intOpacidad;
        private Brush _brushRellenoColor;
        private Color _colorBordeColor;
        private int _intBordeGrosor;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public string TipoFigura
        {
            get { return _strTipoFigura; }
            set { _strTipoFigura = value; }
        }

        public int PosicionX
        {
            get { return _intPosicionX; }
            set { _intPosicionX = value; }
        }

        public int PosicionY
        {
            get { return _intPosicionY; }
            set { _intPosicionY = value; }
        }

        public Size Tamano
        {
            get { return _sizeTamano; }
            set { _sizeTamano = value; }
        }

        public int Opacidad
        {
            get { return _intOpacidad; }
            set { _intOpacidad = value; }
        }

        public Brush RellenoColor
        {
            get { return _brushRellenoColor; }
            set { _brushRellenoColor = value; }
        }

        public int BordeGrosor
        {
            get { return _intBordeGrosor; }
            set { _intBordeGrosor = value; }
        }

        public Color BordeColor
        {
            get { return _colorBordeColor; }
            set { _colorBordeColor = value; }
        }

        public Figura(int PosicionX, int PosicionY, Size Tamano, Brush RellenoColor, Color BordeColor, int BordeGrosor)
        {
            this.PosicionX = PosicionX;
            this.PosicionY = PosicionY;
            this.Tamano = Tamano;
            this.RellenoColor = RellenoColor;
            this.BordeColor = BordeColor;
            this.BordeGrosor = BordeGrosor;
        }

    }
}
