using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Json;

namespace TO_DO_LLIST.Forms
{
    public partial class FormTodoList : Form
    {
        string youraim;
        ImageList imagList;
        private List<Goal> aims = new List<Goal>();
        public FormTodoList()
        {
            InitializeComponent();
            
            //for (int i = 0; i < 15; i++)
            //{
            //    dataGrid.Rows.Add(new object[]
            //    {
            //        imageList.Images[0],
            //        Faker.StringFaker.Alpha(7)
            //    });
            //}
        }
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
            //labelHead.ForeColor = ThemeColor.SecondaryColor;
            
        }
        
        private void FormTodoList_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void dataGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var datagridview = (sender as DataGridView);
            if (e.ColumnIndex == 0)
                datagridview.Cursor = Cursors.Hand;
            else
                datagridview.Cursor = Cursors.Default;
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var datagridview = (sender as DataGridView);
            if (e.ColumnIndex == 0)
            {
                var cell = datagridview.Rows[e.RowIndex].Cells[0];
                if (cell.Tag == null || !(bool)cell.Tag)
                {
                    datagridview.Rows[e.RowIndex].Cells[0].Value = imageList.Images[3];
                    datagridview.Rows[e.RowIndex].Cells[0].Tag = true;
                }
                else
                {
                    datagridview.Rows[e.RowIndex].Cells[0].Value = imageList.Images[0];
                    datagridview.Rows[e.RowIndex].Cells[0].Tag = false;
                }
            }
        }
        Goal goal;
        private void btnAddAim_Click(object sender, EventArgs e)
        {
            youraim = textBoxYourAim.Text;
            imagList = imageList;
            goal = new Goal(youraim, imagList);
            aims.Add(goal);
            // string aim = goal.GetAim();
            //ImageList im = goal.GetImage();
            dataGrid.Rows.Add(goal.ImageList.Images[0],goal.Aim);
            textBoxYourAim.Text = "";
        }

        private void btnDeleteAim_Click(object sender, EventArgs e)
        {
            int colIndx;
            if (MessageBox.Show("Действительно удалить эту запись?",
                    "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    colIndx = dataGrid.CurrentRow.Index;
                    dataGrid.Rows.RemoveAt(colIndx);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Некорректный индекс у строчки !"+ $"{ex.Message}", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить все записи ?",
                    "Удаление всех записей", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dataGrid.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        private void btnSaveAims_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Сохранить все заполненные поля целей ?",
                    "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    var jsonFormater = new DataContractJsonSerializer(typeof(List<Goal>));
                    using (var file = new FileStream("YourAims.json", FileMode.Create))
                    {
                        jsonFormater.WriteObject(file, aims);
                    }
                }
                MessageBox.Show("Успешное сохранение!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка! \n" + ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnReadAims_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Файл прочитан!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                using (var file = new FileStream("YourAims.json", FileMode.OpenOrCreate))
                {
                    var jsonFormater = new DataContractJsonSerializer(typeof(List<Goal>));
                    var newAims = jsonFormater.ReadObject(file) as List<Goal>;
                    foreach (var am in newAims)
                    {
                        dataGrid.Rows.Add(imageList.Images[0], am.Aim);
                    }
                }
            }
           catch(Exception ex)
            {
                MessageBox.Show("Возникла ошибка! \n" + ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormTodoList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить имеющиеся записи ?",
                    "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                btnSaveAims_Click(sender, e);
            }
        }
    }
}
