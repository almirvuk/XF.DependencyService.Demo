using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using XF.DependencyService.Demo.UWP.Helpers;
using XF.DependencyServices.Demo.Helpers;

[assembly: Xamarin.Forms.Dependency(typeof(DatabasePath))]
namespace XF.DependencyService.Demo.UWP.Helpers {

    public class DatabasePath : IDbPath {

        // we must have a default (parameterless) constructor
        public DatabasePath() { }

        // UWP Platform Specific code
        public string GetPlatformDBPath() {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, "LocalDB.db");
        }
    }
}
