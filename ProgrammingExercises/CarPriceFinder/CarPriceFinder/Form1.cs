using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarPriceFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal[] money = new decimal[30];

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'honestRalphsUsedCarsDataSet.tblCars' table. You can move, or remove it, as needed.
            this.tblCarsTableAdapter.Fill(this.honestRalphsUsedCarsDataSet.tblCars);
            int x = 0;
            var cars =
                from c in this.honestRalphsUsedCarsDataSet.tblCars
                select c;
            foreach (var c in cars)
            {
                checkedListBox1.Items.Add(c.ID + " - " + c.ModelYear + " " + c.Make);
                money[x] = c.Price; //populate the array
                ++x;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputLabel.Text = "Price is $" + money[checkedListBox1.SelectedIndex];
        }
    }
}
