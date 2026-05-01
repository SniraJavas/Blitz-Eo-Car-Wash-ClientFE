using BlitzEcoCarWash.Models;
using BlitzEcoCarWash.PageModels;

namespace BlitzEcoCarWash.Pages
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