using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarshallsLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameRadio_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (nameRadio.Checked)
            {
                this.muralsTableAdapter.Fill(this.marshallsDatabaseDataSet.Murals);
                var ms = from m in marshallsDatabaseDataSet.Murals
                         select m;
                foreach (var m in ms)
                    listBox1.Items.Add(m.ClientName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marshallsDatabaseDataSet.Murals' table. You can move, or remove it, as needed.
            

        }

        private void locRadio_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
            if (locRadio.Checked)
            {
                this.muralsTableAdapter.Fill(this.marshallsDatabaseDataSet.Murals);
                var ms = from m in marshallsDatabaseDataSet.Murals
                         group m by (string)m.Location;

                foreach (var groupByLoc in ms)
                {
                    string type;
                    if(groupByLoc.Key.Equals("I"))
                        type = "Interior";
                    else
                        type = "Exterior";
                    listBox1.Items.Add("Location: " + type);
                    foreach (var m in groupByLoc)
                        listBox1.Items.Add("      " + m.ClientName + "  " + m.MuralType);
                }
            }


        }

        private void styleRadio_CheckedChanged(object sender, EventArgs e)
        {
                this.muralsTableAdapter.Fill(this.marshallsDatabaseDataSet.Murals);
                var ms = from m in marshallsDatabaseDataSet.Murals
                         group m by (string)m.MuralType;

                foreach (var groupByStyle in ms)
                {
                    string type;
                    if (groupByStyle.Key.Equals("L"))
                        type = "Landscape";
                    else
                        if (groupByStyle.Key.Equals("S"))
                            type = "Seascape";
                        else
                            if (groupByStyle.Key.Equals("C"))
                                type = "Childrens";
                            else
                                if (groupByStyle.Key.Equals("A"))
                                    type = "Abstract";
                                else
                                   type = "Other";
                    listBox1.Items.Add("Type: " + type);
                    foreach (var m in groupByStyle)
                        listBox1.Items.Add("      " + m.ClientName + "  " + m.MuralType);
                }
        }
    }
}
