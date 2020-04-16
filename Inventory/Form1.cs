using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        private object newItem;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InventoryItem newItem = new InventoryItem();

            newItem.ItemID = 1;
            newItem.Name = "Water Bottle";
            newItem.Description = "Hydro Flask 64 oz. Yellow Stainless Steel";
            newItem.ManufacturerID = "HF64Y";
            newItem.Quantity = 12;
            newItem.Location = "Dallas S1 R4";

            label6.Text = newItem.ItemID.ToString();
            label1.Text = newItem.Name;
            label2.Text = newItem.Description;
            label3.Text = newItem.ManufacturerID;
            label4.Text = newItem.Quantity.ToString();
            label5.Text = newItem.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
