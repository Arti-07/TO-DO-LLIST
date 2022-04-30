using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TO_DO_LLIST.Forms
{
    public partial class FormNotes : Form
    {
        public FormNotes()
        {
            InitializeComponent();
        }
        public FormNotes(string fileName) // Открытие программы документом
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
            {
                try
                {
                    string programmName = Properties.Settings.Default.programmName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file, Encoding.Default);
                    noteBox.Text = reader.ReadToEnd();
                    reader.Close();
                    docPath = fileName;
                    tbChange = false;
                    this.Text = Path.GetFileName(fileName) + " — " + programmName;
                    noteBox.Select(0, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        bool tbChange = false;  // фиксация изменений в блокноте
        string docPath = "";




        private void LoadTheme()  // We apply the colors of the current theme
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            statusStrip1.BackColor = ThemeColor.SecondaryColor;
            //label1.ForeColor = ThemeColor.SecondaryColor;
        }

        private void FormNotes_Load(object sender, EventArgs e)
        {
            LoadTheme();
            noteBox.Font = new Font("Calibri", 16);
        }

        private void tsCancel_Click(object sender, EventArgs e)
        {
            noteBox.Undo();
        }

        private void tsCut_Click(object sender, EventArgs e)
        {
            if (noteBox.SelectedText.Length > 0)
            {
                noteBox.Cut();
            }
        }

        private void tsCopy_Click(object sender, EventArgs e)
        {
            if (noteBox.SelectedText.Length > 0)
            {
                noteBox.Copy();
            }
        }

        private void tsPaste_Click(object sender, EventArgs e)
        {
            noteBox.Paste();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (noteBox.SelectedText.Length > 0)
            {
                noteBox.SelectedText = "";
            }
        }

        private void tsFont_Click(object sender, EventArgs e)
        {
            fontDialog.Font = noteBox.Font;
            DialogResult = fontDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                noteBox.SelectionFont = fontDialog.Font;
            }
        }

        private void tsFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = noteBox.SelectionColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                noteBox.SelectionColor = colorDialog.Color;
            }
        }

        private void FormNotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.formWidth = this.Width;
            // Properties.Settings.Default.formHeight = this.Height;
            Properties.Settings.Default.textTransfer = noteBox.WordWrap;
            Properties.Settings.Default.textFont = noteBox.Font;
            Properties.Settings.Default.statusStripVisible = statusStrip1.Visible;
            Properties.Settings.Default.Save();
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед выходом ?", "Выход из программы",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWorks.SaveFile(ref noteBox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWorks.SaveFileAs(ref noteBox, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void tsOpen_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ ?", "Открытие документа",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWorks.SaveFile(ref noteBox, ref tbChange, ref docPath);
                        FileWorks.OpenFile(ref noteBox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWorks.SaveFileAs(ref noteBox, ref tbChange, ref docPath);
                        FileWorks.OpenFile(ref noteBox, ref tbChange, ref docPath);
                    }
                    else if (message == DialogResult.No)
                    {
                        FileWorks.OpenFile(ref noteBox, ref tbChange, ref docPath);
                    }
                    else return;
                }
                else { FileWorks.OpenFile(ref noteBox, ref tbChange, ref docPath); }

            }
        }

        private void tsSaveAs_Click(object sender, EventArgs e)
        {
            FileWorks.SaveFileAs(ref noteBox, ref tbChange, ref docPath);
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            if (docPath == "")
                FileWorks.SaveFile(ref noteBox, ref tbChange, ref docPath);
            else FileWorks.SaveFileAs(ref noteBox, ref tbChange, ref docPath);
        }

        private void tsExit_Click(object sender, EventArgs e)
        {

        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try { printDocument.Print(); }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка параметров печати !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void noteBox_TextChanged(object sender, EventArgs e)
        {
            tbChange = true;
            WorkWithText.StatusAnalize(ref noteBox, ref statusLineCount, ref statusWordsCount);
        }

        private void tsCreate_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ ? ", "Создание документа ",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWorks.SaveFile(ref noteBox, ref tbChange, ref docPath);
                        FileWorks.CreateFile(ref noteBox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWorks.SaveFileAs(ref noteBox, ref tbChange, ref docPath);
                        FileWorks.CreateFile(ref noteBox, ref tbChange, ref docPath);
                    }
                    else if (message == DialogResult.No)
                    {
                        FileWorks.CreateFile(ref noteBox, ref tbChange, ref docPath);
                    }
                    else { FileWorks.CreateFile(ref noteBox, ref tbChange, ref docPath); }
                }

            }
        }
    }
}
