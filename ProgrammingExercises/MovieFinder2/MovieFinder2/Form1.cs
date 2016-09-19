using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieFinder2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              // TODO: This line of code loads data into the 'moviesDataSet.Movies' table. You can move, or remove it, as needed.
             this.moviesTableAdapter.Fill(this.moviesDataSet.Movies);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                label2.Text = "Movies released before " + textBox1.Text;
                label3.Text = "Movies released in " + textBox1.Text + " or after";
                int year = Convert.ToInt32(textBox1.Text);
                var movies =
                    from m in this.moviesDataSet.Movies
                    orderby m.ReleaseYear
                    select m;
                var oldMovies =
                    from m in movies
                    where m.ReleaseYear < year
                    select m;
                foreach (var m in oldMovies)
                    listBox1.Items.Add(m.ReleaseYear + "  " + m.Title);
                var newMovies =
                    from m in movies
                    where m.ReleaseYear >= year
                    select m;
                foreach (var m in newMovies)
                    listBox2.Items.Add(m.ReleaseYear + "  " + m.Title);

            }
        }
         
    }
}
