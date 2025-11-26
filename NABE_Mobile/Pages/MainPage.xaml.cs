using NABE_Mobile.Models;
using NABE_Mobile.PageModels;

namespace NABE_Mobile.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}