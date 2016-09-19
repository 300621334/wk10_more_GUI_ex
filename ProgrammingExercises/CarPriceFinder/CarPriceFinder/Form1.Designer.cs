namespace CarPriceFinder
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
            this.honestRalphsUsedCarsDataSet = new CarPriceFinder.HonestRalphsUsedCarsDataSet();
            this.tblCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCarsTableAdapter = new CarPriceFinder.HonestRalphsUsedCarsDataSetTableAdapters.tblCarsTableAdapter();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.honestRalphsUsedCarsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // honestRalphsUsedCarsDataSet
            // 
            this.honestRalphsUsedCarsDataSet.DataSetName = "HonestRalphsUsedCarsDataSet";
            this.honestRalphsUsedCarsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCarsBindingSource
            // 
            this.tblCarsBindingSource.DataMember = "tblCars";
            this.tblCarsBindingSource.DataSource = this.honestRalphsUsedCarsDataSet;
            // 
            // tblCarsTableAdapter
            // 
            this.tblCarsTableAdapter.ClearBeforeFill = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(27, 65);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 169);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a car to see its price";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(170, 103);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 15);
            this.outputLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Car Price Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.honestRalphsUsedCarsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HonestRalphsUsedCarsDataSet honestRalphsUsedCarsDataSet;
        private System.Windows.Forms.BindingSource tblCarsBindingSource;
        private HonestRalphsUsedCarsDataSetTableAdapters.tblCarsTableAdapter tblCarsTableAdapter;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
    }
}

