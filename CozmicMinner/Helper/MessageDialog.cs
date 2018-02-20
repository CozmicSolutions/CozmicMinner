namespace CozmicMinner
{
    using System;
    using System.Windows.Forms;

    public enum GPU_ARG
    {
        GPU_FORCE_64BIT_PTR = 0,
        GPU_MAX_HEAP_SIZE = 100,
        GPU_USE_SYNC_OBJECTS = 1,
        GPU_MAX_ALLOC_PERCENT = 100,
        GPU_SINGLE_ALLOC_PERCENT = 100,
    }

    public enum Regions
    {
        asia1 = 1,
        us1 = 2,
        us2 = 3,
        eu1 = 4,
    }

    public enum ServerStatus
    {
        Stopped = 1,
        Running = 2,
    }

    public enum Types
    {
        EthMiner = 1,
        ClaymoresMiner = 2,
    }

    public static class TextStatic
    {
        #region Public Properties

        public static readonly string SFileDateTemplate = "{0:yyyy-MM-dd_hh-mm-ss-ffff-tt}";

        public static string ExpMessageTemplate = "=======<Exception Message>=======" + Environment.NewLine
                                                  + "Error Message :" + Environment.NewLine + "{0}";

        public static string FileDateTemplate = "{0:yyyy-MM-dd_hh-mm-ss-ffff-tt}";

        public static string InnerExpMessageTemplate = "=======<Inner Exception Message>=======" + Environment.NewLine
                                                       + "Inner Exception Error Message :" + Environment.NewLine
                                                       + "{0}";

        public static string InnerStackTraceExpMessageTemplate =
            "=======<Inner Trace Exception Message>=======" + Environment.NewLine + "Inner Trace Error Message :"
            + Environment.NewLine + "{0}";

        public static string StackTraceMessageTemplate = "=======<Trace Exception Message>=======" + Environment.NewLine
                                                         + "Trace Error Message :" + Environment.NewLine + "{0}";

        public static string CancelText
        {
            get
            {
                return "Are you sure you want to cancel and discard all the changes ?";
            }
        }

        public static string HostAddress
        {
            get
            {
                return "ethermine.org";
            }
        }

        public static string SaveText
        {
            get
            {
                return "Are you sure you want to save all the changes ?";
            }
        }

        #endregion Public Properties
    }

    public class MessageDialog
    {
        #region Public Methods

        public static DialogResult ShowErrorMessageBox(Exception ex)
        {
            return MessageBox.Show(ex.ToStringFormat(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.YesNo, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            return MessageBox.Show(text, caption, buttons, icon);
        }

        public static DialogResult ShowYesNoMessageBox(string text, string caption, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            return ShowMessageBox(text, caption, MessageBoxButtons.YesNo, icon);
        }

        #endregion Public Methods
    }
}