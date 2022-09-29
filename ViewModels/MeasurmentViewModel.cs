using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ThermalAdiposer.Models;

namespace ThermalAdiposer.ViewModels
{
    public class MeasurmentViewModel
    {
        private MeasurmentModel _selectedMeasurment;

        public MeasurmentModel SelectedMeasurment
        {
            get { return _selectedMeasurment; }
            set { _selectedMeasurment = value; }
        }
        private ObservableCollection<MeasurmentModel> _measurments = new ObservableCollection<MeasurmentModel>();

        public ObservableCollection<MeasurmentModel> Measurments
        {
            get { return _measurments; }
            set { _measurments = value; }
        }

        public MeasurmentViewModel()
        {
            _measurments.Add(new MeasurmentModel { Name = "Bx1", Min = 30.0f, Max = 32.3f, Average = 31.2f, X = 10, Y = 56, Width = 24, Height = 50 });
            _measurments.Add(new MeasurmentModel { Name = "Bx2", Min = 20.0f, Max = 22.3f, Average = 21.2f, X = 20, Y = 76, Width = 34, Height = 60 });
            _measurments.Add(new MeasurmentModel { Name = "Li1", Min = 23.0f, Max = 28.3f, Average = 25.2f, X = 30, Y = 66, Width = 44, Height = 70 });
            _measurments.Add(new MeasurmentModel { Name = "Sp1", Value = 34.0f, X = 30, Y = 66 });
            _measurments.Add(new MeasurmentModel { Name = "Sp2", Value = 34.0f, X = 30, Y = 66 });
        }
        private ICommand _updateCommand;
        public ICommand UpdateCommand
        {
            get
            {
                if (_updateCommand == null)
                    return new Updater();
                return _updateCommand;
            }
            set
            {
                _updateCommand = value;
            }
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter) => true;

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion
        }
    }
}
