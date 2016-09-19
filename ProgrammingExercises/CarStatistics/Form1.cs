using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarStatistice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'honestRalphsUsedCarsDataSet.tblCars' table. You can move, or remove it, as needed.
            this.tblCarsTableAdapter.Fill(this.honestRalphsUsedCarsDataSet.tblCars);

        }
        private void countButton_Click(object sender, EventArgs e)
        {
            var cars =
             from c in this.honestRalphsUsedCarsDataSet.tblCars
             select c;
            
                countLabel.Text = "We have " + Convert.ToString(cars.Count()) + " cars for sale";
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            var cars =
           from c in this.honestRalphsUsedCarsDataSet.tblCars
           select c.Price;
            foreach (var c in cars)
                maxLabel.Text = "The most expensive car is $" + Convert.ToString(cars.Max());
        }

        private void minButton_Click(object sender, EventArgs e)
        {
                        var cars =
            from c in this.honestRalphsUsedCarsDataSet.tblCars
            select c.Price;
            foreach (var c in cars)
                minLabel.Text = "The least expensive car is $" + Convert.ToString(cars.Min());
        }
    }
}
