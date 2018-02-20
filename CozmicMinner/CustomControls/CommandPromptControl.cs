using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CozmicMinner.CustomControls
{
    using CozmicMinner.Helper;

    public partial class CommandPromptControl : DevExpress.XtraEditors.XtraUserControl
    {
        private ProcessExecute ProcExec = null;
        public CommandPromptControl()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            this.ProcExec = new ProcessExecute();
            this.ProcExec.OutputData += ProcExec_OutputData;
        }

        public void Execute(string fileFullPath)
        {
            this.ProcExec.Create(fileFullPath,false).Start();
           
        }

        public void ExecuteAsync(string fileFullPath)
        {
            this.ProcExec.ExecuteCommandSync(fileFullPath);;

        }

        private void ProcExec_OutputData(string outputLog)
        {
            this.txtOutput.Text += outputLog + Environment.NewLine;

        }
    }
}
