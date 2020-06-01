using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContosoCustomView
{

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ICommand _openCustomPageCommand;

        public MainPage()
        {
            InitializeComponent();
            btnOpenCustomPage.Command = OpenCustomPageCommandAsync;
        }

        public ICommand OpenCustomPageCommandAsync => _openCustomPageCommand ?? (_openCustomPageCommand = new Command(async () =>
        {
            await this.Navigation.PushAsync(new CustomPage());
        }));
    }
}
