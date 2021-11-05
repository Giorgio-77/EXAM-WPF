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
        public byte A { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public ArgbColor() { }
        public ArgbColor(byte a, byte r, byte g, byte b)
            => (A, R, G, B) = (a, r, g, b);

        public Color GetColor()
        {
            Color color = Color.FromArgb(A, R, G, B);
            return color;
        }

        public override string ToString()
        {
            Color color = GetColor();
            return color.A.ToString("X2") + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }
    }
}
