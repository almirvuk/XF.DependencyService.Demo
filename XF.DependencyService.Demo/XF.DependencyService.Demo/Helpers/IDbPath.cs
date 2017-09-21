using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF.DependencyServices.Demo.Helpers {

    public interface IDbPath {

        string GetPlatformDBPath();
    }
}
