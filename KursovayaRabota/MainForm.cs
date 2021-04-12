using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaRabota
{
    public partial class MainForm : Form
    {
        List<Sclad> sclads = new List<Sclad>();
        public List<TextBox> listZapolnenie = new List<TextBox>();

        public MainForm()
        {
            InitializeComponent();
            listZapolnenie.Add(Post);
            listZapolnenie.Add(Prod);
            listZapolnenie.Add(Pr);
            listZapolnenie.Add(Col);
            listZapolnenie.Add(D);
            listZapolnenie.Add(Sg);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseScladDataSet.Sclad". При необходимости она может быть перемещена или удалена.
            this.scladTableAdapter.Fill(this.dataBaseScladDataSet.Sclad);
            dataBaseScladDataSet.Tables[0].AcceptChanges();
            Baza.Sclad_Update(this.Baza_Sclada, this.sclads);
            Baza.Submit_from_database(this.Baza_Sclada, this.sclads);

        }

        private void buttonSearch_Click(object sender, EventArgs e)     //поиск
        {

            if (textBoxS.Text.Length == 0) textBoxS.Text = "Укажите товар!";
            List<Sclad> find_pos = new List<Sclad>();
            find_pos = Baza.Search_Product(this.sclads, textBoxS.Text);
            Baza_Sclada_2.BringToFront();
            Baza_Sclada_2.DataSource = find_pos;
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)      //добавить
        {
            if (Post.Text != "" && Prod.Text != "" && Pr.Text != "" && Col.Text != "" && D.Text != "" && Sg.Text != "")
            {
                DataRow dataRow = dataBaseScladDataSet.Tables[0].NewRow();
                Baza.Add(listZapolnenie, dataRow);
                dataBaseScladDataSet.Tables[0].Rows.Add(dataRow);
                scladTableAdapter.Update(dataBaseScladDataSet.Sclad);
                dataBaseScladDataSet.Tables[0].AcceptChanges();
                Baza_Sclada.Refresh();
                Baza.Sclad_Update(this.Baza_Sclada, this.sclads);
                MessageBox.Show("Новая запись добавлена!");
            }
        }

        private void OK_Click(object sender, EventArgs e)   //изменить
        {
            if (Post.Text != "" && Prod.Text != "" && Col.Text != "" && Pr.Text != "" && D.Text != "" && Sg.Text != "")
            {
                foreach (DataGridViewRow dataGridViewRow in Baza_Sclada.SelectedRows)
                {
                    Baza.izmen(listZapolnenie, dataGridViewRow);
                }
                Baza_Sclada.Refresh();
                Baza.Sclad_Update(this.Baza_Sclada, this.sclads);
                MessageBox.Show("Изменено!");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)       //сохранить
        {
            this.Validate();
            this.scladBindingSource.EndEdit();
            this.scladTableAdapter.Update(this.dataBaseScladDataSet.Sclad);
            dataBaseScladDataSet.Tables[0].AcceptChanges();
            Baza.Sclad_Update(this.Baza_Sclada, this.sclads);
            MessageBox.Show("Сохранено");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Baza_Sclada.BringToFront();
            textBoxS.Clear();
        }

        private void buttonDel_Click(object sender, EventArgs e)        //удалить
        {
            Baza.Sclad_Del(this.Baza_Sclada, this.sclads);
            MessageBox.Show("Удалено!");
        }

        private void Baza_Sclada_SelectionChanged_1(object sender, EventArgs e) //честно не помню что за методы уже но что то с таблицей связано
        {
            foreach (DataGridViewRow row in Baza_Sclada.SelectedRows)
            {
                Baza.Sclad_pokaz2(listZapolnenie, row);
            }
        }

        private void Baza_Sclada2_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Baza_Sclada_2.SelectedRows)
            {
                Baza.Sclad_pokaz(listZapolnenie, row);
                foreach (DataGridViewRow Drow in Baza_Sclada.Rows)
                {
                    if (row.Cells["Postavshik"].Value.ToString() == Drow.Cells["postvshik_"].Value.ToString() &&
                        row.Cells["Product"].Value.ToString() == Drow.Cells["product_"].Value.ToString() &&
                        row.Cells["Colvo"].Value.ToString() == Drow.Cells["colvo_"].Value.ToString() &&
                        row.Cells["Price"].Value.ToString() == Drow.Cells["price_"].Value.ToString() &&
                        row.Cells["Data"].Value.ToString() == Drow.Cells["data_"].Value.ToString() &&
                        row.Cells["Srokgod"].Value.ToString() == Drow.Cells["srokgod_"].Value.ToString())
                    {
                        foreach (DataGridViewRow Drow2 in Baza_Sclada.SelectedRows)
                        {
                            Drow2.Selected = false;
                        }
                        Drow.Selected = true;
                    }
                }
            }
        }
    }
}