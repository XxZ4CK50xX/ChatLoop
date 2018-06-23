using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal class SafeFileDialog
    {
        internal string Title;
        internal string Filter;
        internal string FileName;

        internal static DialogResult ShowDialog()
        {
            throw new NotImplementedException();
        }

        public static implicit operator SafeFileDialog(SaveFileDialog v)
        {
            throw new NotImplementedException();
        }
    }
}