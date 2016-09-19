namespace GreenvilleLinq
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
            this.greenvilleDatabaseDataSet = new GreenvilleLinq.GreenvilleDatabaseDataSet();
            this.contestantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contestantsTableAdapter = new GreenvilleLinq.GreenvilleDatabaseDataSetTableAdapters.ContestantsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.alphaButton = new System.Windows.Forms.RadioButton();
            this.talentButton = new System.Windows.Forms.RadioButton();
            this.specificButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sButton = new System.Windows.Forms.RadioButton();
            this.dButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.oButton = new System.Windows.Forms.RadioButton();
            this.mButton = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.greenvilleDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestantsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // greenvilleDatabaseDataSet
            // 
            this.greenvilleDatabaseDataSet.DataSetName = "GreenvilleDatabaseDataSet";
            this.greenvilleDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contestantsBindingSource
            // 
            this.contestantsBindingSource.DataMember = "Contestants";
            this.contestantsBindingSource.DataSource = this.greenvilleDatabaseDataSet;
            // 
            // contestantsTableAdapter
            // 
            this.contestantsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Greenville Idol Competition\r\n";
            // 
            // alphaButton
            // 
            this.alphaButton.AutoSize = true;
            this.alphaButton.Location = new System.Drawing.Point(16, 19);
            this.alphaButton.Name = "alphaButton";
            this.alphaButton.Size = new System.Drawing.Size(83, 17);
            this.alphaButton.TabIndex = 1;
            this.alphaButton.TabStop = true;
            this.alphaButton.Text = "Alphabetical";
            this.alphaButton.UseVisualStyleBackColor = true;
            // 
            // talentButton
            // 
            this.talentButton.AutoSize = true;
            this.talentButton.Location = new System.Drawing.Point(16, 42);
            this.talentButton.Name = "talentButton";
            this.talentButton.Size = new System.Drawing.Size(55, 17);
            this.talentButton.TabIndex = 2;
            this.talentButton.TabStop = true;
            this.talentButton.Text = "Talent";
            this.talentButton.UseVisualStyleBackColor = true;
            // 
            // specificButton
            // 
            this.specificButton.AutoSize = true;
            this.specificButton.Location = new System.Drawing.Point(16, 65);
            this.specificButton.Name = "specificButton";
            this.specificButton.Size = new System.Drawing.Size(92, 17);
            this.specificButton.TabIndex = 3;
            this.specificButton.TabStop = true;
            this.specificButton.Text = "Specific talent";
            this.specificButton.UseVisualStyleBackColor = true;
            this.specificButton.CheckedChanged += new System.EventHandler(this.specificButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.specificButton);
            this.groupBox1.Controls.Add(this.talentButton);
            this.groupBox1.Controls.Add(this.alphaButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 97);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose view";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sButton
            // 
            this.sButton.AutoSize = true;
            this.sButton.Location = new System.Drawing.Point(23, 19);
            this.sButton.Name = "sButton";
            this.sButton.Size = new System.Drawing.Size(60, 17);
            this.sButton.TabIndex = 6;
            this.sButton.TabStop = true;
            this.sButton.Text = "Singing";
            this.sButton.UseVisualStyleBackColor = true;
            // 
            // dButton
            // 
            this.dButton.AutoSize = true;
            this.dButton.Location = new System.Drawing.Point(23, 42);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(65, 17);
            this.dButton.TabIndex = 7;
            this.dButton.TabStop = true;
            this.dButton.Text = "Dancing";
            this.dButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.oButton);
            this.groupBox2.Controls.Add(this.mButton);
            this.groupBox2.Controls.Add(this.dButton);
            this.groupBox2.Controls.Add(this.sButton);
            this.groupBox2.Location = new System.Drawing.Point(66, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 142);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose talent";
            this.groupBox2.Visible = false;
            // 
            // oButton
            // 
            this.oButton.AutoSize = true;
            this.oButton.Location = new System.Drawing.Point(23, 90);
            this.oButton.Name = "oButton";
            this.oButton.Size = new System.Drawing.Size(51, 17);
            this.oButton.TabIndex = 9;
            this.oButton.TabStop = true;
            this.oButton.Text = "Other";
            this.oButton.UseVisualStyleBackColor = true;
            // 
            // mButton
            // 
            this.mButton.AutoSize = true;
            this.mButton.Location = new System.Drawing.Point(23, 66);
            this.mButton.Name = "mButton";
            this.mButton.Size = new System.Drawing.Size(112, 17);
            this.mButton.TabIndex = 8;
            this.mButton.TabStop = true;
            this.mButton.Text = "Musical instrument";
            this.mButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(247, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 264);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(453, 384);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Greenville Idol";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.greenvilleDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestantsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GreenvilleDatabaseDataSet greenvilleDatabaseDataSet;
        private System.Windows.Forms.BindingSource contestantsBindingSource;
        private GreenvilleDatabaseDataSetTableAdapters.ContestantsTableAdapter contestantsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton alphaButton;
        private System.Windows.Forms.RadioButton talentButton;
        private System.Windows.Forms.RadioButton specificButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton sButton;
        private System.Windows.Forms.RadioButton dButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton oButton;
        private System.Windows.Forms.RadioButton mButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

