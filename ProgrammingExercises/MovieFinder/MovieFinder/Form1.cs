using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieFInder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string lowerCaseData = textBox1.Text.ToLower();
            if (titleButton.Checked == true)
            {
                var movies =
                from m in this.moviesDataSet.Movies
                where m.Title.ToLower().Contains(lowerCaseData)
                select m;
                if (movies.Count() == 0)
                    listBox1.Items.Add("Sorry - no records contain \"" + textBox1.Text + "\"");
                else
                    listBox1.Items.Add("Movie titles containing \"" + textBox1.Text + "\"");
                listBox1.Items.Add("");
                foreach (var m in movies)
                {
                    listBox1.Items.Add("  " + m.Title + "  directed by " + m.Director);
                    listBox1.Items.Add("      Released in " + m.ReleaseYear);
                }
            }
            else
                if (directorButton.Checked == true)
                {
                    var movies =
                     from m in this.moviesDataSet.Movies
                     where m.Director.ToLower().Contains(lowerCaseData)
                     select m;
                    if (movies.Count() == 0)
                        listBox1.Items.Add("Sorry - no records contain \"" + textBox1.Text + "\"");
                    else
                        listBox1.Items.Add("Director's name contains \"" + textBox1.Text + "\"");
                    listBox1.Items.Add("");
                    foreach (var m in movies)
                    {
                        listBox1.Items.Add("   " + m.Title + "  directed by " + m.Director);
                        listBox1.Items.Add("      Released in " + m.ReleaseYear);
                    }
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.moviesDataSet.Movies);

        }
    }
}
