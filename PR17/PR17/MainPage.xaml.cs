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
            string url = "http://numbersapi.com";
            RequestLabel.Text = "";
            using (var WebClient = new WebClient())
            {
                string value = Convert.ToBase64String(Encoding.ASCII.GetBytes(RequestEntry.Text));
                WebClient.Headers.Add("Request", value);
                var response = WebClient.DownloadString(url);
                RequestLabel.Text = Convert.ToString(response);
            }
        }
    }
}
