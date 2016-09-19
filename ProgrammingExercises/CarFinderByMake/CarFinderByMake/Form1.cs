using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarFinderByMake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Display()
        {
            outputBox.Items.Clear();
            if (allBox.Checked)
            {
                var all =
                  from c in this.honestRalphsUsedCarsDataSet.tblCars //NOT whole table but rows
                  select c; //NOT columns but whole-rows
                foreach (var c in all)
                    outputBox.Items.Add
                       (c.Color + " " + c.ModelYear + " " + c.Make + " $" + c.Price);
                cadillacBox.Checked = false;
                chevroletBox.Checked = false;
                fordBox.Checked = false;
            }
            else
            {
                if (cadillacBox.Checked)
                {
                    var fords =
                      from c in this.honestRalphsUsedCarsDataSet.tblCars
                      where c.Make.StartsWith("Cadillac")
                      select c;
                    foreach (var c in fords)
                        outputBox.Items.Add
                           (c.Color + " " + c.ModelYear + " " + c.Make + " $" + c.Price);
                }
                if (chevroletBox.Checked)
                {
                    var cadillacs =
                      from c in this.honestRalphsUsedCarsDataSet.tblCars
                      where c.Make.StartsWith("Chevrolet")
                      select c;
                    foreach (var c in cadillacs)
                        outputBox.Items.Add
                           (c.Color + " " + c.ModelYear + " " + c.Make + " $" + c.Price);
                }
                if (fordBox.Checked)
                {
                    var chevys =
                      from c in this.honestRalphsUsedCarsDataSet.tblCars
                      where c.Make.StartsWith("Ford")
                      select c;
                    foreach (var c in chevys)
                        outputBox.Items.Add
                          (c.Color + " " + c.ModelYear + " " + c.Make + " $" + c.Price);
                }
            }
      
        }

        private void chevoletBox_CheckedChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void fordBox_CheckedChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void allBox_CheckedChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void cadillacBox_CheckedChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'honestRalphsUsedCarsDataSet.tblCars' table. You can move, or remove it, as needed.

            //Table "tblCars" was removed from Form1, so it's not there BUT in bg data is being filled into rblCars by TableAdapter.
            this.tblCarsTableAdapter.Fill(this.honestRalphsUsedCarsDataSet.tblCars);

        }

    }
}


