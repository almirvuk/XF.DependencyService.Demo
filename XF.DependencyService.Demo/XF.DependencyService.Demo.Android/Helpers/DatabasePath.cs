using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XF.DependencyServices.Demo.Droid.Helpers;
using XF.DependencyServices.Demo.Helpers;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(DatabasePath))]
namespace XF.DependencyServices.Demo.Droid.Helpers {

    public class DatabasePath : IDbPath {

        // we must have a default (parameterless) constructor
        public DatabasePath() { }

        public string GetPlatformDBPath() {  

            // Android OS Platform Specific code
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "LocalDB.db");
        }
    }
}