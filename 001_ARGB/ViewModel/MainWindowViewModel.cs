using _001_ARGB.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ARGB.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        ObservableCollection<ArgbColor> _argbColor;

        public ObservableCollection<ArgbColor> ArgbColors
        {
            get
            {
                if (_argbColor == null)
                    _argbColor = ArgbColorRepository.AllColors;
                return _argbColor;
            }
        }

        ArgbColor _currentColor;

        public ArgbColor CurrentClient
        {
            get
            {
                if (_currentColor == null)
                {
                    _currentColor = new ArgbColor();
                }
                return _currentColor;
            }
            set
            {
                _currentColor = value;
                OnPropertyChanged(nameof(CurrentClient));
            }
        }

        ArgbColor _selectedColor;

        public ArgbColor SelectedClient
        {
            get
            {
                if (_selectedColor == null)
                {
                    _selectedColor = new ArgbColor();
                }
                return _selectedColor;
            }
            set
            {
                _selectedColor = value;
                OnPropertyChanged(nameof(SelectedClient));
            }
        }




        protected override void OnDispose()
        {
            this.ArgbColors.Clear();
        }
    }
}
