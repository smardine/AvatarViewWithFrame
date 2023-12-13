using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MauiApp4
{
    public partial class MainVM : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> liste;

        public MainVM()
        {
            Liste = new ObservableCollection<string>
                        {
                            "AZ","ER","ty"
                        };

        }
    }
    public partial class MainPage : ContentPage
    {
        int count = 0;


        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainVM();

        }

       
    }

}
