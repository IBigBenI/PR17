using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using System.Collections.Specialized;

namespace PR17
{
    public partial class MainPage : ContentPage
    {    
        public MainPage()
        {
            InitializeComponent();
        }
        private void RequestClick(object sender, EventArgs e)
        {
            string url = "http://numbersapi.com/";
            if (RequestEntry.Text.Contains('.'))
            {
                RequestLabel.Text = "Введено некорректное число";
            }
            else
            {
                using (var WebClient = new WebClient())
                {
                    var response = WebClient.DownloadString(url + RequestEntry.Text);
                    RequestLabel.Text = Convert.ToString(response);
                }
            }         
        }
    }
}
