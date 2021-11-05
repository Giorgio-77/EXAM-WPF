using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace _001_ARGB.Model
{
    class ArgbColor
    {
        private byte a;
        private byte r;
        private byte g;
        private byte b;

        public byte A
        {
            get => a;

            set
            {
                a = value;
                SetHex();
            }
        }

        public byte R
        {
            get => r;

            set
            {
                r = value;
                SetHex();
            }
        }

        public byte G
        {
            get => g;

            set
            {
                g = value;
                SetHex();
            }
        }

        public byte B
        {
            get => b;

            set
            {
                b = value;
                SetHex();
            }
        }

        public string Hex { get; set; }

        public ArgbColor()
            => (A, R, G, B) = (0,0,0,0);
        public ArgbColor(double a, double r, double g, double b)
            => (A, R, G, B) = ((byte)a, (byte)r, (byte)g, (byte)b);

        public void SetHex()
        {
            Color color = Color.FromArgb(A, R, G, B);
            Hex = "#" + color.A.ToString("X2") + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }
    }
}
