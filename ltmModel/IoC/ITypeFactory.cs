using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ltm.IoC
{
    public interface ITypeFactory
    {
        T CreateInstance<T>(params object[] p) where T : class, new();
    }
}
