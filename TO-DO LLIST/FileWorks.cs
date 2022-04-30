using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TO_DO_LLIST
{
    class FileWorks
    {
        public static void CreateFile(ref RichTextBox notebox, ref bool tbChange, ref string docPath) //Метод создания нового документа
        {
            string newDocName = Properties.Settings.Default.newDocName;
            string programName = Properties.Settings.Default.programmName;
            notebox.Clear();
            docPath = "";
            tbChange = false;
           // Forms.FormNotes.ActiveForm.Text = newDocName + " - " + programName;
        }
        public static void OpenFile(ref RichTextBox notebox, ref bool tbChange, ref string docPath) // Метод для "Открыть документ"
        {
            string programName = Properties.Settings.Default.programmName;
            OpenFileDialog openDocument = new OpenFileDialog();
            openDocument.Title = "Открыть текстовый документ";
            openDocument.Filter = "Текстовые файлы (*.txt) | *.txt| Все файлы (*.*)|*.*";
            if (openDocument.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(openDocument.FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file, Encoding.Default);
                notebox.Text = reader.ReadToEnd();
                reader.Close();
                docPath = openDocument.FileName;
                tbChange = false;
                //MainForm.ActiveForm.Text = openDocument.SafeFileName + " — " + programName;
            }
        }
        public static void SaveFile(ref RichTextBox notebox, ref bool tbChange, ref string docPath) // Метод для сохранения документа
        {
            FileStream file = new FileStream(docPath, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file, Encoding.Default);
            writer.Write(notebox.Text);
            writer.Close();
            tbChange = false;
        }
        public static void SaveFileAs(ref RichTextBox notebox, ref bool tbChange, ref string docPath)  // Метод "сохранить документ как"...
        {
            //string programName = Properties.Settings.Default.programmName;
            SaveFileDialog saveAsDocument = new SaveFileDialog();
            saveAsDocument.Title = "Сохранить документ как...";
            saveAsDocument.FileName = " Новый текстовый документ";
            saveAsDocument.Filter = "Текстовые файлы (*.txt) |*.txt| Все файлы (*.*)|*.*";
            if (saveAsDocument.ShowDialog() == DialogResult.OK) //пользователь подтверждает сохранение
            {
                // Создаем файл по пути, выбранному в окне сохранения
                FileStream file = new FileStream(saveAsDocument.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file, Encoding.Default);
                writer.Write(notebox.Text);    // записываем в файл
                writer.Close();                // закрываем поток
                tbChange = false;
                docPath = saveAsDocument.FileName;
               // Forms.FormNotes.ActiveForm.Text = Path.GetFileName(saveAsDocument.FileName) + " — " + programName;
            }
            else { tbChange = true; return; }
        }
    }
}

