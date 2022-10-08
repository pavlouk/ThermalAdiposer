using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ThermalAdiposer.Models;
using ThermalAdiposer.Core;
using System.Windows;
using ThermalAdiposer.Views;

namespace ThermalAdiposer.ViewModels
{
    public class MeasurmentViewModel: ObservableObject
    {
        private MeasurmentModel _selectedMeasurment;
        private ObservableCollection<MeasurmentModel> _measurments = new ObservableCollection<MeasurmentModel>();

        public MeasurmentViewModel()
        {
            _measurments.Add(new MeasurmentModel { Name = "Bx1", Min = 30.0f, Max = 32.3f, Average = 31.2f, X = 10, Y = 56, Width = 24, Height = 50 });
            _measurments.Add(new MeasurmentModel { Name = "Bx2", Min = 20.0f, Max = 22.3f, Average = 21.2f, X = 20, Y = 76, Width = 34, Height = 60 });
            _measurments.Add(new MeasurmentModel { Name = "Li1", Min = 23.0f, Max = 28.3f, Average = 25.2f, X = 30, Y = 66, Width = 44, Height = 70 });
            _measurments.Add(new MeasurmentModel { Name = "Sp1", Value = 34.0f, X = 30, Y = 66 });
            _measurments.Add(new MeasurmentModel { Name = "Sp2", Value = 34.0f, X = 30, Y = 66 });
        }

        public ObservableCollection<MeasurmentModel> Measurments
        {
            get { return _measurments; }
            set { _measurments = value; }
        }
        public MeasurmentModel SelectedMeasurment
        {
            get { return _selectedMeasurment; }
            set { _selectedMeasurment = value; }
        }

        private void AddMeasurment()
        {
            _measurments.Add(new MeasurmentModel { Name = "Li1", Min = 23.0f, Max = 28.3f, Average = 25.2f, X = 30, Y = 66, Width = 44, Height = 70 } );
        }

        private ICommand _showCommand;
        public ICommand ShowCommand
        {
            get
            {
                if (_showCommand == null)
                    _showCommand = new RelayCommand(p => AddMeasurment());
                return _showCommand;
            }
        }

        private void UpdateMeasurment()
        {
            OnPropertyChanged(nameof(SelectedMeasurment));
        }

        private ICommand _updtCommand;
        public ICommand UpdtCommand
        {
            get
            {
                if (_updtCommand == null)
                    _updtCommand = new RelayCommand(p => UpdateMeasurment());
                return _updtCommand;
            }
        }
    }
}
