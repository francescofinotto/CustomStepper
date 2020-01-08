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
        public static readonly BindableProperty ValueBindable = BindableProperty.Create("Value", typeof(int), typeof(CustomStepper));
        public int Max { get; set; }
        public int Min { get; set; }
        public int CurrentValue { get { return (int)GetValue(ValueBindable); } set { SetValue(ValueBindable, value); } }

        public event Action OnValueCanged;
        public CustomStepper()
        {
            InitializeComponent();
        }

        private void ButtonPlus_Clicked(object sender, EventArgs e)
        {
            CurrentValue++;
        }

        private void ButtonMinus_Clicked(object sender, EventArgs e)
        {
            CurrentValue--;
        }
    }
}