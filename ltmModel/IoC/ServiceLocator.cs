using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace ltm.IoC
{
    public sealed class ServiceLocator
    {
        private ServiceLocator _locator = new ServiceLocator();
        private readonly object _lock = new object();
        private IKernel _injector;

        private ServiceLocator()
        {
            this.InitializeServices();
        }

        private void InitializeServices()
        {
            INinjectModule[] m = new INinjectModule[]
            {

            };

            this._injector = new StandardKernel(m);
        }

        public ServiceLocator Default
        {
            get
            {
                if ( _locator == null )
                {
                    lock(_lock)
                    {
                        _locator = new ServiceLocator();
                    }
                }

                return _locator;
            }
        }

        public IKernel Ninject
        {
            get
            {
                return this._injector;
            }
        }
    }
}
