using _001_ARGB.Infrastructure;
using _001_ARGB.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _001_ARGB.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        ObservableCollection<ArgbColor> _argbColors;

        public ObservableCollection<ArgbColor> ArgbColors
        {
            get
            {
                if (_argbColors == null)
                    _argbColors = ArgbColorRepository.AllColors;
                return _argbColors;
            }
        }

        ArgbColor _currentColor;

        public ArgbColor CurrentColor
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
                OnPropertyChanged(nameof(CurrentColor));
            }
        }

        ArgbColor _selectedColor;

        public ArgbColor SelectedColor
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
                OnPropertyChanged(nameof(SelectedColor));
            }
        }

        // commands...
        //add
        RelayCommand _addColorCommand;

        public ICommand AddColorCommand
        {
            get
            {
                if (_addColorCommand == null)
                    _addColorCommand = new RelayCommand(ExecuteAddColorCommand, CanExecuteAddColorCommand);
                return _addColorCommand;
            }
        }

        public void ExecuteAddColorCommand(object parameter)
        {
            ArgbColors.Add(CurrentColor);
            CurrentColor = null;
        }

        public bool CanExecuteAddColorCommand(object parameter)
        {
            var result = ArgbColors.Where(item => item.Hex == CurrentColor.Hex).ToArray();
            if (result.Length != 0 || CurrentColor.Hex == "#00000000")
                return false;
            return true;
        }

        // delete



        protected override void OnDispose()
        {
            this.ArgbColors.Clear();
        }
    }
}
