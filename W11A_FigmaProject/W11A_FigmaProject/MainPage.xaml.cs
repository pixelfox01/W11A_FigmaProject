using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace W11A_FigmaProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            WorkshopPicker.ItemsSource = WorkshopRepository.Workshops;
        }

        private void enrolmentFormButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EnrollPage(WorkshopPicker.SelectedItem as Workshop));
        }
    }
}
