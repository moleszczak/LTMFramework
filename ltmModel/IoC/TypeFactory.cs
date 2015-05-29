using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ltm.IoC
{
    public class TypeFactory : ITypeFactory
    {
        public T CreateInstance<T>(params object[] p) where T : class, new()
        {
            var t = typeof(T);
            ConstructorInfo cInfo = t.GetType().

            return new T();
        }
    }
}
