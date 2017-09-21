using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.DependencyServices.Demo.Helpers;

namespace XF.DependencyServices.Demo {

    public partial class MainPage : ContentPage {

        public MainPage() {

            InitializeComponent();
        }

        private void ShowDatabsePath(object sender, EventArgs e) {

            // Usage of DependencyService
            var dbPath = DependencyService.Get<IDbPath>().GetPlatformDBPath();

            // Displaying the result from GetPlatformDBPath()
            DisplayAlert("Db Path:", dbPath, "Ok");
        }
    }
}
