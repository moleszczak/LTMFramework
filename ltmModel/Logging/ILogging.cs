using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ltm.Logging
{
    public interface ILogging
    {
        void Debug(string msg, params object[] extra);
        Task DebugAsync(string msg, params object[] extra);

        void Info(string msg, params object[] extra);
        Task InfoAsync(string msg, params object[] extra);

        void Warning(string msg, params object[] extra);
        Task WarningAsync(string msg, params object[] extra);

        void Error(string msg, params object[] extra);
        Task ErrorAsync(string msg, params object[] extra);

        void Error(Exception ex);
        Task ErrorAsync(Exception ex);
    }
}
