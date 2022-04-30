using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TO_DO_LLIST
{
    class WorkWithText
    {
        public static void StatusAnalize(ref RichTextBox notebox, ref ToolStripStatusLabel statusLinesCount, ref ToolStripStatusLabel statusWordsCount)
        {
            string text = notebox.Text;
            // Количество строк в тексте
            statusLinesCount.Text = notebox.Lines.Count().ToString();
            // Количество слов в тексте
            statusWordsCount.Text = text.Split(new Char[] { ' ', '\t', '\n', '\r', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-',
                '_', '+', '=', '[', '{', ']', '}', '/', '\\', '|', '"', ':', ';', '.', ',', '>', '<' },
                StringSplitOptions.RemoveEmptyEntries).Length.ToString();

        }
    }
}
