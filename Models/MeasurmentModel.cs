using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThermalAdiposer.Core;

namespace ThermalAdiposer.Models
{
    public class MeasurmentModel: ObservableObject
    {
		private string _name;
		private float _value;
		private float _min;
		private float _max;
		private float _average;
		private int _x;
		private int _y;
		private int _width;
		private int _height;

		public string Name
		{
			get { return _name; }
			set 
			{ 
				_name = value;
				OnPropertyChanged(nameof(Name));
			}
		}

		public float Value
		{
			get { return _value; }
			set 
			{ 
				_value = value;
				OnPropertyChanged(nameof(Value));
			}
		}

		public float Min
		{
			get { return _min; }
			set 
			{ 
				_min = value;
				OnPropertyChanged(nameof(Min));
			}
		}

		public float Max
		{
			get { return _max; }
			set 
			{ 
				_max = value;
				OnPropertyChanged(nameof(Max));
			}
		}

		public float Average
		{
			get { return _average; }
			set 
			{ 
				_average = value;
				OnPropertyChanged(nameof(Average));
			}
		}

		public int X
		{
			get { return _x; }
			set 
			{ 
				_x = value;
				OnPropertyChanged(nameof(X));
			}
		}

		public int Y
		{
			get { return _y; }
			set 
			{ 
				_y = value;
				OnPropertyChanged(nameof(Y));
			}
		}

		public int Width
		{
			get { return _width; }
			set 
			{ 
				_width = value;
				OnPropertyChanged(nameof(Width));
			}
		}

		public int Height
		{
			get { return _height; }
			set 
			{ 
				_height = value;
				OnPropertyChanged(nameof(Height));
			}
		}
    }
}
