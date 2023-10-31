using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsWpf;

namespace SimpleCalculatorMVVMWpfApp
{
    public class MainViewModel : ObserverVM
    {
		private int firstNumber;
			
		public int FirstNumber
		{
			get { return firstNumber; }
			set { firstNumber = value;
			OnPropertyChanged(nameof(FirstNumber));
			}
		}
		private int secondNumber;

		public int SecondNumber
		{
			get { return secondNumber; }
			set { 
				secondNumber = value;
				OnPropertyChanged(nameof(SecondNumber));
			}
		}
		private int resoult;

		public int Resoult
		{
			get { return resoult; }
			set { resoult = value;
				OnPropertyChanged(nameof(Resoult));
			}
		}

	}
}
