using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeApp
{
    

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

        private  void Btn_clicked2(object sender, EventArgs e)
        {
            DoConversions();
        }

        private void Picker(object sender, EventArgs e)
        {
            DoConversions();
        }

        private void DoConversions()
        {
            string answer="",min;
            double hours = Convert.ToDouble(Hours.Text);
            double entry = Convert.ToDouble(numberEntered.Text);
            double minutes = Convert.ToDouble(Minutes.Text);
            double ans;

            while (minutes>=60)
            {
                minutes = minutes - 60;
                hours++;
            }
            
            if(minutes<=9)
            {
                min = "0" + minutes;
            }
            else
            {
                min = Convert.ToString(minutes);
            }

            

            ans = hours + entry;

            if (ans >= 24)
            {
                ans = ans - 24;
                answer = Convert.ToString(ans) + ":" + min + " the next day";
            }
            else if (ans<0)
            {
                ans = ans + 24;
                answer = Convert.ToString(ans) + ":" + min + " the day before";
            }
            else
            { 
                answer = Convert.ToString(ans) +":"+ min;
            }
        output.Text = Convert.ToString(answer);
        }


    }
}