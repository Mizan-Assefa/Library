namespace Librarysystem
{
    partial class Isuebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Isuebook));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.departmentisu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameisu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numberisu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isuubook = new System.Windows.Forms.DataGridView();
            this.phoneisu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stcb = new System.Windows.Forms.ComboBox();
            this.Bookisu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isuubook)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(991, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 80);
            this.label1.TabIndex = 22;
            this.label1.Text = "Library managment system \r\n               Issue Books";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(-7, 632);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 56);
            this.panel1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(60, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 32);
            this.label6.TabIndex = 62;
            this.label6.Text = "STID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(44)))), ((int)(((byte)(36)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(217, 561);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 46);
            this.button4.TabIndex = 61;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(44)))), ((int)(((byte)(36)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(160, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 46);
            this.button1.TabIndex = 58;
            this.button1.Text = "Issue Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // departmentisu
            // 
            this.departmentisu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentisu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.departmentisu.Location = new System.Drawing.Point(229, 276);
            this.departmentisu.Multiline = true;
            this.departmentisu.Name = "departmentisu";
            this.departmentisu.Size = new System.Drawing.Size(252, 45);
            this.departmentisu.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(56, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 32);
            this.label5.TabIndex = 56;
            this.label5.Text = "Department";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // nameisu
            // 
            this.nameisu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameisu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.nameisu.Location = new System.Drawing.Point(229, 213);
            this.nameisu.Multiline = true;
            this.nameisu.Name = "nameisu";
            this.nameisu.Size = new System.Drawing.Size(252, 45);
            this.nameisu.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(60, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 54;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // numberisu
            // 
            this.numberisu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberisu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.numberisu.Location = new System.Drawing.Point(229, 153);
            this.numberisu.Multiline = true;
            this.numberisu.Name = "numberisu";
            this.numberisu.Size = new System.Drawing.Size(252, 45);
            this.numberisu.TabIndex = 53;
            this.numberisu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(60, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 52;
            this.label2.Text = "Num";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // isuubook
            // 
            this.isuubook.BackgroundColor = System.Drawing.Color.White;
            this.isuubook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.isuubook.GridColor = System.Drawing.Color.White;
            this.isuubook.Location = new System.Drawing.Point(558, 112);
            this.isuubook.Name = "isuubook";
            this.isuubook.RowHeadersWidth = 62;
            this.isuubook.RowTemplate.Height = 28;
            this.isuubook.Size = new System.Drawing.Size(509, 495);
            this.isuubook.TabIndex = 64;
            // 
            // phoneisu
            // 
            this.phoneisu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneisu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.phoneisu.Location = new System.Drawing.Point(229, 335);
            this.phoneisu.Multiline = true;
            this.phoneisu.Name = "phoneisu";
            this.phoneisu.Size = new System.Drawing.Size(252, 45);
            this.phoneisu.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(60, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 65;
            this.label3.Text = "Phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // stcb
            // 
            this.stcb.FormattingEnabled = true;
            this.stcb.Location = new System.Drawing.Point(229, 112);
            this.stcb.Name = "stcb";
            this.stcb.Size = new System.Drawing.Size(252, 28);
            this.stcb.TabIndex = 67;
            this.stcb.SelectionChangeCommitted += new System.EventHandler(this.stcb_SelectionChangeCommitted);
            this.stcb.SelectedValueChanged += new System.EventHandler(this.stcb_SelectedValueChanged);
            // 
            // Bookisu
            // 
            this.Bookisu.FormattingEnabled = true;
            this.Bookisu.Location = new System.Drawing.Point(229, 395);
            this.Bookisu.Name = "Bookisu";
            this.Bookisu.Size = new System.Drawing.Size(252, 28);
            this.Bookisu.TabIndex = 69;
            this.Bookisu.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(65, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 32);
            this.label7.TabIndex = 68;
            this.label7.Text = "Book";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(69, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 32);
            this.label8.TabIndex = 70;
            this.label8.Text = "Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 433);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 26);
            this.dateTimePicker1.TabIndex = 71;
            // 
            // Isuebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1091, 688);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Bookisu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stcb);
            this.Controls.Add(this.phoneisu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isuubook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.departmentisu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameisu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberisu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Isuebook";
            this.Text = "Isuebook";
            this.Load += new System.EventHandler(this.Isuebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isuubook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox departmentisu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameisu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberisu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView isuubook;
        private System.Windows.Forms.TextBox phoneisu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stcb;
        private System.Windows.Forms.ComboBox Bookisu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}