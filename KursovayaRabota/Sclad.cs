using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaRabota
{
    public class Sclad //тут переменные другие делаешь если надо и просто меняешь аналогично всему
    {
        int id;
        string postavshik;
        string product;
        int colvo;
        double price;
        DateTime data;
        DateTime srokgod;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Postavshik
        {
            get { return postavshik; }
            set { postavshik = value; }
        }
        public string Product
        {
            get { return product; }
            set { product = value; }
        }
        public int Colvo
        {
            get { return colvo; }
            set { colvo = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public DateTime Data  
        {
            get { return data; }
            set { data = value; }
        }
        public DateTime Srokgod
        {
            get { return srokgod; }
            set { srokgod = value; }
        }

        public Sclad() { }
        public void _sclad(DataGridViewRow viewRow)
        {
            this.Id = Convert.ToInt32(viewRow.Cells["id_"].Value);
            this.Postavshik = viewRow.Cells["postavshik_"].Value.ToString();
            this.Product = viewRow.Cells["product_"].Value.ToString();
            this.Colvo = Convert.ToInt32(viewRow.Cells["colvo_"].Value);
            this.Price = Convert.ToDouble(viewRow.Cells["price_"].Value);
            this.Data = Convert.ToDateTime(viewRow.Cells["data_"].Value);
            this.Srokgod = Convert.ToDateTime(viewRow.Cells["srokgod_"].Value);
        }
    }
}