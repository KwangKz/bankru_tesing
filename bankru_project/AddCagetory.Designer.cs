namespace bankru_project
{
    partial class AddCagetory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CageDGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.inputcagetory = new System.Windows.Forms.TextBox();
            this.Addcagebtn = new System.Windows.Forms.Button();
            this.DGVcurrent = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deletecagetorybtn = new System.Windows.Forms.Button();
            this.delinput = new System.Windows.Forms.ComboBox();
            this.Candel = new System.Windows.Forms.Button();
            this.OKdel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CageDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(757, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Cagetory";
            // 
            // CageDGV
            // 
            this.CageDGV.AllowUserToAddRows = false;
            this.CageDGV.AllowUserToDeleteRows = false;
            this.CageDGV.AllowUserToResizeColumns = false;
            this.CageDGV.AllowUserToResizeRows = false;
            this.CageDGV.ColumnHeadersHeight = 40;
            this.CageDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CageDGV.Location = new System.Drawing.Point(26, 113);
            this.CageDGV.Name = "CageDGV";
            this.CageDGV.ReadOnly = true;
            this.CageDGV.RowHeadersVisible = false;
            this.CageDGV.Size = new System.Drawing.Size(340, 154);
            this.CageDGV.TabIndex = 1;
            this.CageDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CageDGV_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 36);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cagetory Name :";
            // 
            // inputcagetory
            // 
            this.inputcagetory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.inputcagetory.Location = new System.Drawing.Point(409, 291);
            this.inputcagetory.Name = "inputcagetory";
            this.inputcagetory.Size = new System.Drawing.Size(256, 35);
            this.inputcagetory.TabIndex = 26;
            // 
            // Addcagebtn
            // 
            this.Addcagebtn.BackColor = System.Drawing.Color.LightGreen;
            this.Addcagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Addcagebtn.Location = new System.Drawing.Point(221, 351);
            this.Addcagebtn.Name = "Addcagebtn";
            this.Addcagebtn.Size = new System.Drawing.Size(145, 45);
            this.Addcagebtn.TabIndex = 27;
            this.Addcagebtn.Text = "Add Cagetory";
            this.Addcagebtn.UseVisualStyleBackColor = false;
            this.Addcagebtn.Click += new System.EventHandler(this.Addcagebtn_Click);
            // 
            // DGVcurrent
            // 
            this.DGVcurrent.ColumnHeadersHeight = 40;
            this.DGVcurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVcurrent.Location = new System.Drawing.Point(433, 113);
            this.DGVcurrent.Name = "DGVcurrent";
            this.DGVcurrent.RowHeadersVisible = false;
            this.DGVcurrent.Size = new System.Drawing.Size(340, 154);
            this.DGVcurrent.TabIndex = 28;
            this.DGVcurrent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcurrent_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cagetory Using";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cagetory Current";
            // 
            // deletecagetorybtn
            // 
            this.deletecagetorybtn.BackColor = System.Drawing.Color.Salmon;
            this.deletecagetorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.deletecagetorybtn.Location = new System.Drawing.Point(433, 351);
            this.deletecagetorybtn.Name = "deletecagetorybtn";
            this.deletecagetorybtn.Size = new System.Drawing.Size(167, 45);
            this.deletecagetorybtn.TabIndex = 31;
            this.deletecagetorybtn.Text = "Delete Cagetory";
            this.deletecagetorybtn.UseVisualStyleBackColor = false;
            this.deletecagetorybtn.Click += new System.EventHandler(this.deletecagetorybtn_Click);
            // 
            // delinput
            // 
            this.delinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.delinput.FormattingEnabled = true;
            this.delinput.Location = new System.Drawing.Point(409, 291);
            this.delinput.Name = "delinput";
            this.delinput.Size = new System.Drawing.Size(256, 32);
            this.delinput.TabIndex = 32;
            // 
            // Candel
            // 
            this.Candel.BackColor = System.Drawing.Color.DarkSalmon;
            this.Candel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Candel.Location = new System.Drawing.Point(433, 351);
            this.Candel.Name = "Candel";
            this.Candel.Size = new System.Drawing.Size(167, 45);
            this.Candel.TabIndex = 33;
            this.Candel.Text = "Cancel";
            this.Candel.UseVisualStyleBackColor = false;
            this.Candel.Click += new System.EventHandler(this.Candel_Click);
            // 
            // OKdel
            // 
            this.OKdel.BackColor = System.Drawing.Color.LightGreen;
            this.OKdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.OKdel.Location = new System.Drawing.Point(221, 351);
            this.OKdel.Name = "OKdel";
            this.OKdel.Size = new System.Drawing.Size(145, 45);
            this.OKdel.TabIndex = 34;
            this.OKdel.Text = "OK";
            this.OKdel.UseVisualStyleBackColor = false;
            this.OKdel.Click += new System.EventHandler(this.OKdel_Click);
            // 
            // AddCagetory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.OKdel);
            this.Controls.Add(this.Candel);
            this.Controls.Add(this.delinput);
            this.Controls.Add(this.deletecagetorybtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVcurrent);
            this.Controls.Add(this.Addcagebtn);
            this.Controls.Add(this.inputcagetory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CageDGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCagetory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCagetory";
            this.Load += new System.EventHandler(this.AddCagetory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CageDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcurrent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CageDGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputcagetory;
        private System.Windows.Forms.Button Addcagebtn;
        private System.Windows.Forms.DataGridView DGVcurrent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deletecagetorybtn;
        private System.Windows.Forms.ComboBox delinput;
        private System.Windows.Forms.Button Candel;
        private System.Windows.Forms.Button OKdel;
    }
}