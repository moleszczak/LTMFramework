using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ltm.Model
{
    public class ModelBase : NotifyObject
    {
        public ModelBase()
            : base()
        {
            this.IsDirty = false;
        }

        public bool IsDirty { get; set; }

    }
}
