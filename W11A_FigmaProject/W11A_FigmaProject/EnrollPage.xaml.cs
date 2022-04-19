using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace W11A_FigmaProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnrollPage : ContentPage
    {
        public EnrollPage(Workshop workshop)
        {
            InitializeComponent();
        }
    }
}