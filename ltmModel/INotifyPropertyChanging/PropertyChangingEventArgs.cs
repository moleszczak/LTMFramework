using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ltm.Model
{
    public class PropertyChangingEventArgs : EventArgs
    {
        #region initialization

        public PropertyChangingEventArgs(string propertyName, object previousValue, object newValue)
            : base()
        {
            this.PreviousValue = previousValue;
            this.NewValue = newValue;
            this.PropertyName = propertyName;
            this.CancelChange = false;
        }

        public PropertyChangingEventArgs(string propertyName)
            : this(propertyName, null, null)
        {
        }

        #endregion

        #region properties

        /// <summary>
        /// property name that is changing
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// previous value of property that is going to be changed
        /// </summary>
        public object PreviousValue { get; set; }

        /// <summary>
        /// new value of property that is going to be set
        /// </summary>
        public object NewValue { get; set; }

        /// <summary>
        /// cancel change made by user
        /// </summary>
        public bool CancelChange { get; set; }

        #endregion
    }
}
