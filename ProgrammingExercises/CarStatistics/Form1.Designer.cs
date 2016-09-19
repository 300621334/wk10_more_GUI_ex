namespace CarStatistice
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
            this.label1 = new System.Windows.Forms.Label();
            this.honestRalphsUsedCarsDataSet = new CarStatistice.HonestRalphsUsedCarsDataSet();
            this.tblCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCarsTableAdapter = new CarStatistice.HonestRalphsUsedCarsDataSetTableAdapters.tblCarsTableAdapter();
            this.countButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.honestRalphsUsedCarsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "View statistics about our cars";
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
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(26, 67);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(103, 55);
            this.countButton.TabIndex = 1;
            this.countButton.Text = "How many cars do we have?";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(26, 128);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(103, 47);
            this.maxButton.TabIndex = 2;
            this.maxButton.Text = "How much is the most expensive car?";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // minButton
            // 
            this.minButton.Location = new System.Drawing.Point(26, 189);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(103, 48);
            this.minButton.TabIndex = 3;
            this.minButton.Text = "How much is the least expensive car?";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(140, 82);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(0, 13);
            this.countLabel.TabIndex = 4;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(140, 142);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(0, 13);
            this.maxLabel.TabIndex = 5;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(140, 202);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(0, 13);
            this.minLabel.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.modelYearDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCarsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(196, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // modelYearDataGridViewTextBoxColumn
            // 
            this.modelYearDataGridViewTextBoxColumn.DataPropertyName = "ModelYear";
            this.modelYearDataGridViewTextBoxColumn.HeaderText = "ModelYear";
            this.modelYearDataGridViewTextBoxColumn.Name = "modelYearDataGridViewTextBoxColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Car Statistics";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.honestRalphsUsedCarsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HonestRalphsUsedCarsDataSet honestRalphsUsedCarsDataSet;
        private System.Windows.Forms.BindingSource tblCarsBindingSource;
        private HonestRalphsUsedCarsDataSetTableAdapters.tblCarsTableAdapter tblCarsTableAdapter;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
    }
}

