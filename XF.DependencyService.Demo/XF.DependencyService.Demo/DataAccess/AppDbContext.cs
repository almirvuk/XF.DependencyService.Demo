using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF.DependencyServices.Demo.DataAccess {

    public class AppDbContext {

        public string DbPath { get; private set; }

        public AppDbContext() {

            // Here we need to set our DbPath value from platform where
            // app is running at this moment.
            

        }
    }
}
