using Deflamingo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Deflamingo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}