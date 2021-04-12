using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data;

namespace KursovayaRabota
{
    public static class Baza
    {
        public static void Submit_from_database(DataGridView dataGridView, List<Sclad> listSclad)           //Отправка из базы данных в  List<Sclad> listSclad(лист)
        {
            foreach (DataGridViewRow ryad in dataGridView.Rows)
            {
                Sclad sclad = new Sclad();
                sclad._sclad(ryad);
                listSclad.Add(sclad);
            }
        }

        public static void izmen(List<TextBox> listSclad, DataGridViewRow ryad)         //изменить
        {
            char list = listSclad[0].Text[0];
            ryad.Cells["postavshik_"].Value = listSclad[0].Text;
            list = listSclad[1].Text[0];
            ryad.Cells["product_"].Value = listSclad[1].Text; //тоже самое (поменять)
            list = listSclad[2].Text[0];
            ryad.Cells["colvo_"].Value = listSclad[2].Text;
            ryad.Cells["price_"].Value = listSclad[3].Text;
            ryad.Cells["data_"].Value = listSclad[4].Text;
            ryad.Cells["srokgod_"].Value = listSclad[5].Text; //тут поменять (у меня стоит срок годности в БД
        }

        public static void Add(List<TextBox> listSclad, DataRow ryad)     //добавить
        {
            char list = listSclad[0].Text[0]; //аналогично также меняешь то что меняла выше и везде во всем коде проверяй переменные и поля
            ryad["postavshik"] = listSclad[0].Text;
            list = listSclad[1].Text[0];
            ryad["product"] = listSclad[1].Text;
            list = listSclad[2].Text[0];
            ryad["colvo"] = listSclad[2].Text;
            ryad["price"] = listSclad[3].Text;
            ryad["data"] = listSclad[4].Text;
            ryad["srokgod"] = listSclad[5].Text;
        }

        public static void Sclad_Update(DataGridView dataGridView, List<Sclad> listSclad)          //обновление первого (листа)
        {
            listSclad.Clear();
            foreach (DataGridViewRow dataGridViewRow in dataGridView.Rows)
            {
                Sclad sclad = new Sclad();
                sclad._sclad(dataGridViewRow);
                listSclad.Add(sclad);
            }
        }

        public static void Sclad_Del(DataGridView dataGridView, List<Sclad> listSclad)      //Удалить
        {
            foreach (DataGridViewRow dataGridViewRow in dataGridView.SelectedRows)
            {
                dataGridView.Rows.Remove(dataGridViewRow);
            }
            Baza.Sclad_Update(dataGridView, listSclad);
        }

        public static List<Sclad> Search_Product(List<Sclad> listS, string str)         //Поиск по товару
        {
            List<Sclad> list = new List<Sclad>();
            foreach (Sclad product_ in listS)
            {
                if (product_.Product.ToLower().Contains(str.ToLower()))
                {
                    list.Add(product_);
                }
            }
            return list;
        }
        public static void Sclad_pokaz(List<TextBox> textBoxes, DataGridViewRow dataGridViewRow)        //отображение
        {
            textBoxes[0].Text = dataGridViewRow.Cells["Postavshik"].Value.ToString();
            textBoxes[1].Text = dataGridViewRow.Cells["Product"].Value.ToString();
            textBoxes[2].Text = dataGridViewRow.Cells["Colvo"].Value.ToString();
            textBoxes[3].Text = dataGridViewRow.Cells["Price"].Value.ToString();
            textBoxes[4].Text = dataGridViewRow.Cells["Data"].Value.ToString();
            textBoxes[5].Text = dataGridViewRow.Cells["Srokgod"].Value.ToString();
        }
        public static void Sclad_pokaz2(List<TextBox> textBoxes, DataGridViewRow dataGridViewRow)        //другое отображение
        {
            textBoxes[0].Text = dataGridViewRow.Cells["postavshik_"].Value.ToString();
            textBoxes[1].Text = dataGridViewRow.Cells["product_"].Value.ToString();
            textBoxes[2].Text = dataGridViewRow.Cells["colvo_"].Value.ToString();
            textBoxes[3].Text = dataGridViewRow.Cells["price_"].Value.ToString();
            textBoxes[4].Text = dataGridViewRow.Cells["data_"].Value.ToString();
            textBoxes[5].Text = dataGridViewRow.Cells["srokgod_"].Value.ToString();
        }
    }
}
