namespace bankru_project
{
    partial class ManageProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Addmp = new System.Windows.Forms.Button();
            this.MPdgv = new System.Windows.Forms.DataGridView();
            this.MPnote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MPcagetory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MPunit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MPsellingprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MPcostprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MPname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MPbarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Product";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Addmp);
            this.panel1.Controls.Add(this.MPdgv);
            this.panel1.Controls.Add(this.MPnote);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.MPcagetory);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.MPunit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.MPsellingprice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.MPcostprice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.MPname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MPbarcode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(19, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 691);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.Location = new System.Drawing.Point(989, 493);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 61);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(989, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 61);
            this.button2.TabIndex = 19;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(989, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 61);
            this.button1.TabIndex = 18;
            this.button1.Text = "Barcode";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Addmp
            // 
            this.Addmp.BackColor = System.Drawing.Color.LawnGreen;
            this.Addmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Addmp.Location = new System.Drawing.Point(989, 329);
            this.Addmp.Name = "Addmp";
            this.Addmp.Size = new System.Drawing.Size(149, 61);
            this.Addmp.TabIndex = 17;
            this.Addmp.Text = "Add";
            this.Addmp.UseVisualStyleBackColor = false;
            this.Addmp.Click += new System.EventHandler(this.Addmp_Click);
            // 
            // MPdgv
            // 
            this.MPdgv.AllowUserToAddRows = false;
            this.MPdgv.AllowUserToDeleteRows = false;
            this.MPdgv.AllowUserToResizeColumns = false;
            this.MPdgv.AllowUserToResizeRows = false;
            this.MPdgv.ColumnHeadersHeight = 40;
            this.MPdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MPdgv.Location = new System.Drawing.Point(30, 307);
            this.MPdgv.Name = "MPdgv";
            this.MPdgv.ReadOnly = true;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.MPdgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MPdgv.Size = new System.Drawing.Size(896, 359);
            this.MPdgv.TabIndex = 16;
            this.MPdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MPdgv_CellContentClick);
            // 
            // MPnote
            // 
            this.MPnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MPnote.Location = new System.Drawing.Point(933, 135);
            this.MPnote.Name = "MPnote";
            this.MPnote.Size = new System.Drawing.Size(248, 31);
            this.MPnote.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(655, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Note :";
            // 
            // MPcagetory
            // 
            this.MPcagetory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MPcagetory.Location = new System.Drawing.Point(933, 84);
            this.MPcagetory.Name = "MPcagetory";
            this.MPcagetory.Size = new System.Drawing.Size(248, 31);
            this.MPcagetory.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(655, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 36);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cagetory Name :";
            // 
            // MPunit
            // 
            this.MPunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MPunit.Location = new System.Drawing.Point(933, 216);
            this.MPunit.Name = "MPunit";
            this.MPunit.Size = new System.Drawing.Size(248, 31);
            this.MPunit.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(655, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Units In Stock :";
            // 
            // MPsellingprice
            // 
            this.MPsellingprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MPsellingprice.Location = new System.Drawing.Point(357, 241);
            this.MPsellingprice.Name = "MPsellingprice";
            this.MPsellingprice.Size = new System.Drawing.Size(248, 31);
            this.MPsellingprice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Selling Price :";
            // 
            // MPcostprice
            // 
            this.MPcostprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MPcostprice.Location = new System.Drawing.Point(357, 188);
            this.MPcostprice.Name = "MPcostprice";
            this.MPcostprice.Size = new System.Drawing.Size(248, 31);
            this.MPcostprice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost Price :";
            // 
            // MPname
            // 
            this.MPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MPname.Location = new System.Drawing.Point(357, 134);
            this.MPname.Name = "MPname";
            this.MPname.Size = new System.Drawing.Size(248, 31);
            this.MPname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Name :";
            // 
            // MPbarcode
            // 
            this.MPbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MPbarcode.Location = new System.Drawing.Point(357, 83);
            this.MPbarcode.Name = "MPbarcode";
            this.MPbarcode.Size = new System.Drawing.Size(248, 31);
            this.MPbarcode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Barcode :";
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1241, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MPbarcode;
        private System.Windows.Forms.TextBox MPcostprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MPname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MPsellingprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MPunit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MPcagetory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Addmp;
        private System.Windows.Forms.DataGridView MPdgv;
        private System.Windows.Forms.TextBox MPnote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}