using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ARGB.Model
{
    class ArgbColorRepository
    {
        private static ObservableCollection<ArgbColor> _argbColors;

        public static ObservableCollection<ArgbColor> AllColors
        {
            get
            {
                if (_argbColors == null)
                {
                    _argbColors = generateClientRepository();
                }
                return _argbColors;
            }
        }

        private static ObservableCollection<ArgbColor> generateClientRepository()
        {
            ObservableCollection<ArgbColor> argbColors = new ObservableCollection<ArgbColor>();

            argbColors.Add(new ArgbColor(200,10,200,12));
            argbColors.Add(new ArgbColor(100,15,200,255));
            argbColors.Add(new ArgbColor(200,200,200,200));
            argbColors.Add(new ArgbColor(255,15,15,250));

            return argbColors;
        }
    }
}
