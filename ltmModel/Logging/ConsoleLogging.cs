using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DG = System.Diagnostics;

namespace ltm.Logging
{
    public class ConsoleLogging : ILogging
    {
        public void Debug(string msg, params object[] extra)
        {
            Task.Run(() => this.DebugAsync(msg, extra).Wait());
        }

        async public Task DebugAsync(string msg, params object[] extra)
        {
            await this.WriteLogToDebugConsole(msg, extra);
        }

        public void Error(Exception ex)
        {
            Task.Run(() => this.ErrorAsync(ex)).Wait();
        }

        public void Error(string msg, params object[] extra)
        {
            Task.Run(() => this.ErrorAsync(msg, extra)).Wait();
        }

        public async Task ErrorAsync(Exception ex)
        {
            await this.WriteLogToDebugConsole(ex.Message);
        }

        public async Task ErrorAsync(string msg, params object[] extra)
        {
            await this.WriteLogToDebugConsole(msg, extra);
        }

        public void Info(string msg, params object[] extra)
        {
            Task.Run(() => this.InfoAsync(msg, extra)).Wait();
        }

        public async Task InfoAsync(string msg, params object[] extra)
        {
            await this.WriteLogToDebugConsole(msg, extra);
        }

        public void Warning(string msg, params object[] extra)
        {
            Task.Run(() => this.WarningAsync(msg, extra));
        }

        public async Task WarningAsync(string msg, params object[] extra)
        {
            await this.WriteLogToDebugConsole(msg, extra);
        }

        #region helper methods

        private async Task WriteLogToDebugConsole(string msg, params object[] extra)
        {
            await Task.Run(() => { DG.Debug.WriteLine(msg, extra); });
        }

        #endregion
    }
}
