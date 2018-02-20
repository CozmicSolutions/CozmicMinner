using System;

namespace CozmicMinner.Helper
{
    using System.Diagnostics;
    using System.Threading;

    public delegate void OutputDataDelegate(string outputLog);

    public class ProcessExecute
    {
        #region Private Fields

        Process process = null;

        #endregion Private Fields

        #region Public Events

        public event OutputDataDelegate OutputData;

        #endregion Public Events

        #region Public Methods

        public void Create(ProcessStartInfo startInfo)
        {
            this.process = new Process { StartInfo = startInfo };
            this.process.OutputDataReceived += this.CaptureOutput;
            this.process.ErrorDataReceived += this.CaptureError;
        }

        public Process Create(string fileFullPath, bool createNoWindow)
        {
            this.process = new Process();
            this.process.StartInfo.FileName = fileFullPath;
            this.process.StartInfo.RedirectStandardInput = true;
            this.process.StartInfo.RedirectStandardOutput = true;
            this.process.StartInfo.CreateNoWindow = createNoWindow;
            this.process.StartInfo.UseShellExecute = false;
            this.process.OutputDataReceived += this.CaptureOutput;
            this.process.ErrorDataReceived += this.CaptureError;
            return this.process;
        }

        /// <summary>
        /// ExecuteCommandAsync
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteCommandAsync(string command)
        {
            try
            {
                var objThread = new Thread(new ParameterizedThreadStart(this.ExecuteCommandSync));
                objThread.IsBackground = true;
                objThread.Priority = ThreadPriority.AboveNormal;
                objThread.Start(command);
            } catch(ThreadStartException objException)
            {
            } catch(ThreadAbortException objException)
            {
            } catch(Exception objException)
            {
            }
        }

        /// <summary>
        /// ExecuteCommandSync
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteCommandSync(object command)
        {
            try
            {
                var procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd",
                                                            "/c " +
                    command);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                var proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                var result = proc.StandardOutput.ReadToEnd();
                this.ShowOutput(result);
            } catch(Exception objException)
            {
            }
        }

        /// <summary>
        ///      Start 
        /// </summary>
        /// <param name="fileFullPath">  </param>
        /// <param name="createNoWindow"></param>
        /// <returns></returns>
        public bool Start(string fileFullPath, bool createNoWindow)
        {
            this.process = new Process();
            this.process.StartInfo.FileName = fileFullPath;
            this.process.StartInfo.RedirectStandardInput = true;
            this.process.StartInfo.RedirectStandardOutput = true;
            this.process.StartInfo.CreateNoWindow = createNoWindow;
            this.process.StartInfo.UseShellExecute = false;
            this.process.OutputDataReceived += this.CaptureOutput;
            this.process.ErrorDataReceived += this.CaptureError;
            return this.process.Start();
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        ///      CaptureError 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        void CaptureError(object sender, DataReceivedEventArgs e)
        {
            this.ShowOutput(e.Data);
        }

        /// <summary>
        ///      CaptureOutput 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        void CaptureOutput(object sender, DataReceivedEventArgs e)
        {
            this.ShowOutput(e.Data);
        }

        /// <summary>
        ///      ShowOutput 
        /// </summary>
        /// <param name="data"> </param>
        /// <param name="color"></param>
        void ShowOutput(string data)
        {
            if(data != null)
            {
                if(this.OutputData.IsNotNull())
                {
                    this.OutputData("Received: " + data);
                }
            }
        }
        #endregion Private Methods
    }
}