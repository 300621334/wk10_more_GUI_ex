namespace MovieFInder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleButton = new System.Windows.Forms.RadioButton();
            this.directorButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.moviesDataSet = new MovieFInder.MoviesDataSet();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new MovieFInder.MoviesDataSetTableAdapters.MoviesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleButton
            // 
            this.titleButton.AutoSize = true;
            this.titleButton.Location = new System.Drawing.Point(26, 55);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(92, 17);
            this.titleButton.TabIndex = 0;
            this.titleButton.TabStop = true;
            this.titleButton.Text = "Search by title";
            this.titleButton.UseVisualStyleBackColor = true;
            // 
            // directorButton
            // 
            this.directorButton.AutoSize = true;
            this.directorButton.Location = new System.Drawing.Point(26, 79);
            this.directorButton.Name = "directorButton";
            this.directorButton.Size = new System.Drawing.Size(111, 17);
            this.directorButton.TabIndex = 1;
            this.directorButton.TabStop = true;
            this.directorButton.Text = "Search by director";
            this.directorButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter part of the title or director name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 161);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 160);
            this.listBox1.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(105, 116);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // moviesDataSet
            // 
            this.moviesDataSet.DataSetName = "MoviesDataSet";
            this.moviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.moviesDataSet;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 340);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directorButton);
            this.Controls.Add(this.titleButton);
            this.Name = "Form1";
            this.Text = "Movie Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton titleButton;
        private System.Windows.Forms.RadioButton directorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button searchButton;
        private MoviesDataSet moviesDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private MoviesDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
    }
}

