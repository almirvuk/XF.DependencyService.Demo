using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XF.DependencyService.Demo.iOS.Helpers;
using XF.DependencyServices.Demo.Helpers;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(DatabasePath))]
namespace XF.DependencyService.Demo.iOS.Helpers {

    public class DatabasePath : IDbPath { 

        // we must have a default (parameterless) constructor
        public DatabasePath() {}

        // iOS Platform Specific code
        public string GetPlatformDBPath() {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", "LocalDB.db");
        }
    }
}