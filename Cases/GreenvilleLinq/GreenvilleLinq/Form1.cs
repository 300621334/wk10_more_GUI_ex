using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'greenvilleDatabaseDataSet.Contestants' table. You can move, or remove it, as needed.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.contestantsTableAdapter.Fill(this.greenvilleDatabaseDataSet.Contestants);
            listBox1.Items.Clear();
            if (alphaButton.Checked)
            {
                var contestants =
                  from c in this.greenvilleDatabaseDataSet.Contestants
                  orderby c.ContestantName
                  select c;
                foreach (var c in contestants)
                    listBox1.Items.Add(c.ContestantName + "  " + c.Talent);
            }
            else
            {
                if (talentButton.Checked)
                {
                    var contestants =
                        from c in greenvilleDatabaseDataSet.Contestants
                        group c by (string)c.Talent;
                    foreach (var groupByTalent in contestants)
                    {
                        listBox1.Items.Add("Talent: " + groupByTalent.Key);
                        foreach (var c in groupByTalent)
                            listBox1.Items.Add("      " + c.ContestantName);
                    }
                }
                else
                {
                    if (specificButton.Checked)
                    {
                        if (sButton.Checked)
                        {
                            var contestants =
                               from c in this.greenvilleDatabaseDataSet.Contestants
                               orderby c.ContestantName
                               where c.Talent.Equals("S")
                               select c;
                            foreach (var c in contestants)
                                listBox1.Items.Add(c.ContestantName);
                        }
                        else if (dButton.Checked)
                        {
                            var contestants =
                               from c in this.greenvilleDatabaseDataSet.Contestants
                               orderby c.ContestantName
                               where c.Talent.Equals("D")
                               select c;
                            foreach (var c in contestants)
                                listBox1.Items.Add(c.ContestantName);
                        }
                        else if (mButton.Checked)
                        {
                            var contestants =
                               from c in this.greenvilleDatabaseDataSet.Contestants
                               orderby c.ContestantName
                               where c.Talent.Equals("M")
                               select c;
                            foreach (var c in contestants)
                                listBox1.Items.Add(c.ContestantName);
                        }
                        else if (oButton.Checked)
                        {
                            var contestants =
                               from c in this.greenvilleDatabaseDataSet.Contestants
                               orderby c.ContestantName
                               where c.Talent.Equals("O")
                               select c;
                            foreach (var c in contestants)
                                listBox1.Items.Add(c.ContestantName);
                        }
                    }
                }
            }
        }

        private void specificButton_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBox2.Visible == false)
                groupBox2.Visible = true;

            else
                groupBox2.Visible = false;
        }
    }
}
