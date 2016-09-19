namespace MarshallsLinq
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.nameRadio = new System.Windows.Forms.RadioButton();
            this.locRadio = new System.Windows.Forms.RadioButton();
            this.styleRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.marshallsDatabaseDataSet = new MarshallsLinq.MarshallsDatabaseDataSet();
            this.muralsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muralsTableAdapter = new MarshallsLinq.MarshallsDatabaseDataSetTableAdapters.MuralsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marshallsDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muralsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marshall\'s Murals";
            // 
            // nameRadio
            // 
            this.nameRadio.AutoSize = true;
            this.nameRadio.Location = new System.Drawing.Point(15, 47);
            this.nameRadio.Name = "nameRadio";
            this.nameRadio.Size = new System.Drawing.Size(79, 28);
            this.nameRadio.TabIndex = 1;
            this.nameRadio.TabStop = true;
            this.nameRadio.Text = "Name";
            this.nameRadio.UseVisualStyleBackColor = true;
            this.nameRadio.CheckedChanged += new System.EventHandler(this.nameRadio_CheckedChanged);
            // 
            // locRadio
            // 
            this.locRadio.AutoSize = true;
            this.locRadio.Location = new System.Drawing.Point(15, 81);
            this.locRadio.Name = "locRadio";
            this.locRadio.Size = new System.Drawing.Size(99, 28);
            this.locRadio.TabIndex = 2;
            this.locRadio.TabStop = true;
            this.locRadio.Text = "Location";
            this.locRadio.UseVisualStyleBackColor = true;
            this.locRadio.CheckedChanged += new System.EventHandler(this.locRadio_CheckedChanged);
            // 
            // styleRadio
            // 
            this.styleRadio.AutoSize = true;
            this.styleRadio.Location = new System.Drawing.Point(16, 115);
            this.styleRadio.Name = "styleRadio";
            this.styleRadio.Size = new System.Drawing.Size(68, 28);
            this.styleRadio.TabIndex = 3;
            this.styleRadio.TabStop = true;
            this.styleRadio.Text = "Style";
            this.styleRadio.UseVisualStyleBackColor = true;
            this.styleRadio.CheckedChanged += new System.EventHandler(this.styleRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.styleRadio);
            this.groupBox1.Controls.Add(this.locRadio);
            this.groupBox1.Controls.Add(this.nameRadio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select view";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(166, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 264);
            this.listBox1.TabIndex = 5;
            // 
            // marshallsDatabaseDataSet
            // 
            this.marshallsDatabaseDataSet.DataSetName = "MarshallsDatabaseDataSet";
            this.marshallsDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muralsBindingSource
            // 
            this.muralsBindingSource.DataMember = "Murals";
            this.muralsBindingSource.DataSource = this.marshallsDatabaseDataSet;
            // 
            // muralsTableAdapter
            // 
            this.muralsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(380, 376);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Marshall\'s Murals";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marshallsDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muralsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton nameRadio;
        private System.Windows.Forms.RadioButton locRadio;
        private System.Windows.Forms.RadioButton styleRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private MarshallsDatabaseDataSet marshallsDatabaseDataSet;
        private System.Windows.Forms.BindingSource muralsBindingSource;
        private MarshallsDatabaseDataSetTableAdapters.MuralsTableAdapter muralsTableAdapter;

    }
}

