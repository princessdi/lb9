using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Pyramid _model;

        public double BaseSide
        {
            get => _model.BaseSide;
            set 
            {
                _model.BaseSide = value; 
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
                OnPropertyChanged(nameof(Volume));
            }
        }

        public double Height
        {
            get => _model.Height;
            set 
            {
                _model.Height = value; 
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
                OnPropertyChanged(nameof(Volume));
            }
        }

        public double? Area => _model.IsValid ? _model.BaseArea + _model.Apothem * (_model.BaseSide * 2 / 3) : null;
        public double? Volume => _model.IsValid ? _model.BaseArea * _model.Height / 3 : null;

        public MainViewModel()
        {
            _model = new Pyramid();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
