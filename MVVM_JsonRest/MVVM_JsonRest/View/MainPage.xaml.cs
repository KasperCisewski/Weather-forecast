using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM_JsonRest.View
{
	public partial class MainPage : ContentPage
	{
        ViewModel.MainPageViewModel vm;
		public MainPage()
		{
            vm = new ViewModel.MainPageViewModel();
            BindingContext = vm;
            InitializeComponent();
        }
        public async void OnClicked(object o, EventArgs e)
        {

            var longitude = double.Parse(Lon.Text);
            var latitude = double.Parse(Lat.Text);


            // var url = string.Format("https://api.geonames.org/findNearByWeatherJSON?formatted=true&lat={0}&lng={1}&username=demo&style=full",latitude,longitude);
            // I'dont have a access to geonames, so I can`t use my Entry values.
            var url = string.Format("http://api.geonames.org/findNearByWeatherJSON?formatted=true&lat=42&lng=-2&username=demo&style=full"); 

            await vm.GetWeatherAsync(url);
        }
    }
}
