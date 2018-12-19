using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HoursAdded : ContentPage
    {
        public HoursAdded()
        {
            InitializeComponent();
        }

        private async void Btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }


     }
    
}