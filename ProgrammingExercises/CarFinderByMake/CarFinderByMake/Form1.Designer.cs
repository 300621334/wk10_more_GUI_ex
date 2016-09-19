namespace CarFinderByMake
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
            this.cadillacBox = new System.Windows.Forms.CheckBox();
            this.chevroletBox = new System.Windows.Forms.CheckBox();
            this.fordBox = new System.Windows.Forms.CheckBox();
            this.allBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.honestRalphsUsedCarsDataSet = new CarFinderByMake.HonestRalphsUsedCarsDataSet();
            this.tblCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCarsTableAdapter = new CarFinderByMake.HonestRalphsUsedCarsDataSetTableAdapters.tblCarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.honestRalphsUsedCarsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cadillacBox
            // 
            this.cadillacBox.AutoSize = true;
            this.cadillacBox.Location = new System.Drawing.Point(34, 58);
            this.cadillacBox.Name = "cadillacBox";
            this.cadillacBox.Size = new System.Drawing.Size(63, 17);
            this.cadillacBox.TabIndex = 0;
            this.cadillacBox.Text = "Cadillac";
            this.cadillacBox.UseVisualStyleBackColor = true;
            this.cadillacBox.CheckedChanged += new System.EventHandler(this.cadillacBox_CheckedChanged);
            // 
            // chevroletBox
            // 
            this.chevroletBox.AutoSize = true;
            this.chevroletBox.Location = new System.Drawing.Point(34, 92);
            this.chevroletBox.Name = "chevroletBox";
            this.chevroletBox.Size = new System.Drawing.Size(71, 17);
            this.chevroletBox.TabIndex = 1;
            this.chevroletBox.Text = "Chevrolet";
            this.chevroletBox.UseVisualStyleBackColor = true;
            this.chevroletBox.CheckedChanged += new System.EventHandler(this.chevoletBox_CheckedChanged);
            // 
            // fordBox
            // 
            this.fordBox.AutoSize = true;
            this.fordBox.Location = new System.Drawing.Point(140, 58);
            this.fordBox.Name = "fordBox";
            this.fordBox.Size = new System.Drawing.Size(47, 17);
            this.fordBox.TabIndex = 2;
            this.fordBox.Text = "Ford";
            this.fordBox.UseVisualStyleBackColor = true;
            this.fordBox.CheckedChanged += new System.EventHandler(this.fordBox_CheckedChanged);
            // 
            // allBox
            // 
            this.allBox.AutoSize = true;
            this.allBox.Location = new System.Drawing.Point(140, 92);
            this.allBox.Name = "allBox";
            this.allBox.Size = new System.Drawing.Size(37, 17);
            this.allBox.TabIndex = 3;
            this.allBox.Text = "All";
            this.allBox.UseVisualStyleBackColor = true;
            this.allBox.CheckedChanged += new System.EventHandler(this.allBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select as many makes as you want";
            // 
            // outputBox
            // 
            this.outputBox.FormattingEnabled = true;
            this.outputBox.Location = new System.Drawing.Point(34, 132);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(182, 212);
            this.outputBox.TabIndex = 5;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 376);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allBox);
            this.Controls.Add(this.fordBox);
            this.Controls.Add(this.chevroletBox);
            this.Controls.Add(this.cadillacBox);
            this.Name = "Form1";
            this.Text = "Car Finder by Make";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.honestRalphsUsedCarsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cadillacBox;
        private System.Windows.Forms.CheckBox chevroletBox;
        private System.Windows.Forms.CheckBox fordBox;
        private System.Windows.Forms.CheckBox allBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox outputBox;
        private HonestRalphsUsedCarsDataSet honestRalphsUsedCarsDataSet;
        private System.Windows.Forms.BindingSource tblCarsBindingSource;
        private HonestRalphsUsedCarsDataSetTableAdapters.tblCarsTableAdapter tblCarsTableAdapter;
    }
}

