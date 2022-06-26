using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Compass_test
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        CompassViewModel vm;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = vm = new CompassViewModel();
            vm.StartCompass();

        }
    }
}
