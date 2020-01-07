using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TPSoftware.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomStepper : Grid
    {
        public int Max { get; set; }
        public int Min { get; set; }
        public int Value { get; set; }

        public event Action OnValueCanged;
        public CustomStepper()
        {
            InitializeComponent();
        }

        private void ButtonPlus_Clicked(object sender, EventArgs e)
        {
            Value++;
        }

        private void ButtonMinus_Clicked(object sender, EventArgs e)
        {
            Value--;
        }
    }
}