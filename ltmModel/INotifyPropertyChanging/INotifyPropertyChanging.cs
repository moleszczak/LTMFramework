using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ltm.Model
{
    public interface INotifyPropertyChanging
    {
        event PropertyChangingEventHandler PropertyChanging;
    }
}
