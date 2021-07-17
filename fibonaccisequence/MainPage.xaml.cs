using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using fibonaccisequence.NumberGenerator;
using Xamarin.Forms;

namespace fibonaccisequence
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class NumberGeneratorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand MyCommand { private set; get; }

        string numberLabelText;
        public string NumberLabelText
        {
            set
            {
                if (numberLabelText != value)
                {
                    numberLabelText = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NumberLabelText"));
                }
            }
            get
            {
                return numberLabelText;
            }
        }

        private FibonacciSequence fibonaccisequence;// = new FibonacciSequence();

        public NumberGeneratorViewModel()
        {
            MyCommand = new Command(execute: () =>
            {
                fibonaccisequence = fibonaccisequence.NextSequence();
                NumberLabelText = fibonaccisequence.Current.ToString();
            });
            fibonaccisequence = new FibonacciSequence();
            NumberLabelText = fibonaccisequence.Current.ToString();

        }
    }
}
