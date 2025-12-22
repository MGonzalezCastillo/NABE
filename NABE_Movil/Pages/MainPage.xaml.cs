using NABE_Movil.Models;
using NABE_Movil.PageModels;

namespace NABE_Movil.Pages
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