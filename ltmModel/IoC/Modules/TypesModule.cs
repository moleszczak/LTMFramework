using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace ltm.IoC
{
    using Logging;

    public class TypesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogging>().To<ConsoleLogging>();
        }
    }
}
