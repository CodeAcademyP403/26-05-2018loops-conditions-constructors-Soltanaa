using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Et");
            comboBox1.Items.Add("Terevez");
            comboBox1.Items.Add("Sirniyyat");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void ProductInfo()
        {
            Product product = new Product();
            product.Name = textBox1.Text;
            product.Weight = textBox2.Text;
            product.Price = textBox3.Text;
            product.Date = textBox4.Text;
            product.ID = 0;
            
           // MessageBox.Show("Stokdaki mal sayi:5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Stock: "+comboBox1.Text+" - "+textBox1.Text+" - "+textBox2.Text+" - "+textBox3.Text+" - " +textBox4.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";


            //yaz bildiyim bu qeder oldu.o biri sertleri yaza bilmedim...--


            //Category category = new Category();
            //Product product = new Product();
            //Stock[] stocks = new Stock[4];
           // stocks[0] = comboBox1.Text;
           // stock[1] = textBox1.Text;
           // stock[2] = textBox2.Text;

        //    category.Name = comboBox1.Text;

        //    if (category.Name == "Et")
        //    {  
        //        ProductInfo();
        //        Count(product.ID);
        //      //  MessageBox.Show(product.ID);
        //    }
        //    else if (category.Name == "Sirniyyat")
        //    { ProductInfo(); }
        //    else if(category.Name == "Terevez")
        //    { ProductInfo(); }

        }
        public void Count(int count)
        {
            count++;
            Convert.ToString(count);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
