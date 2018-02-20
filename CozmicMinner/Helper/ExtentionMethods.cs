using System;
using System.Text;

namespace CozmicMinner
{
    using Telerik.WinControls.UI;

    public static class ExtensionMethods
    {
        #region Public Methods

        public static T GetValue<T>(this RadDropDownList rdButton)
        {
            if (rdButton.SelectedItem == null) return default(T);

            if (rdButton.SelectedItem.Value is T)
            {
                return (T)rdButton.SelectedItem.Value;
            }
            else
            {
                try
                {
                    return (T)Convert.ChangeType(rdButton.SelectedItem.Value, typeof(T));
                }
                catch (InvalidCastException e)
                {
                    return default(T);
                }
            }
        }

        public static bool IsGuidNull(this Guid obj)
        {
            return obj == null || obj == Guid.Empty;
        }

        public static bool IsNotNull(this object obj)
        {
            return obj != null;
        }

        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        public static string ToStringFormat(this Exception ex)
        {
            var builder = new StringBuilder();
            builder.AppendLine("Time Stamp : " + DateTime.Today.ToString("YYYYMMDDTHH:MM:SS")
                               + Environment.NewLine + "Log Text : ");
            builder.AppendLine("[" + ex.GetType() + "]");
            builder.AppendFormat(TextStatic.ExpMessageTemplate, ex.Message);
            if (!string.IsNullOrEmpty(ex.StackTrace))
                builder.AppendFormat(TextStatic.StackTraceMessageTemplate, ex.StackTrace);
            if (ex.InnerException != null)
                builder.AppendFormat(TextStatic.InnerExpMessageTemplate, ex.InnerException);
            if (ex.InnerException?.StackTrace != null)
                builder.AppendFormat(TextStatic.InnerStackTraceExpMessageTemplate, ex.InnerException.StackTrace);
            return builder.ToString();
        }

        public static bool TryGetValue<T>(this RadDropDownList rdButton, out T value)
        {
            value = default(T);
            if (rdButton.SelectedItem == null) return false;

            if (rdButton.SelectedItem.Value is T)
            {
                value = (T)rdButton.SelectedItem.Value;
                return true;
            }
            else
            {
                try
                {
                    value = (T)Convert.ChangeType(rdButton.SelectedItem.Value, typeof(T));
                    return true;
                }
                catch (InvalidCastException)
                {
                    value = default(T);

                    return false;
                }
            }
        }

        #endregion Public Methods
    }
}