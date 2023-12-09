namespace bankru_project
{
    partial class Member
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
            this.memcage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idinsert = new System.Windows.Forms.TextBox();
            this.Nameinsert = new System.Windows.Forms.TextBox();
            this.desinsert = new System.Windows.Forms.TextBox();
            this.pTECPOSDataSet = new bankru_project.PTECPOSDataSet();
            this.cagetorytblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cagetorytblTableAdapter = new bankru_project.PTECPOSDataSetTableAdapters.CagetorytblTableAdapter();
            this.testingbox = new System.Windows.Forms.TextBox();
            this.ptecposDataSet1 = new bankru_project.PTECPOSDataSet();
            this.CatData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pTECPOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cagetorytblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptecposDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatData)).BeginInit();
            this.SuspendLayout();
            // 
            // memcage
            // 
            this.memcage.AutoSize = true;
            this.memcage.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memcage.Location = new System.Drawing.Point(482, 43);
            this.memcage.Name = "memcage";
            this.memcage.Size = new System.Drawing.Size(262, 36);
            this.memcage.TabIndex = 0;
            this.memcage.Text = "Member Cagetory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(153, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(281, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 44);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idinsert
            // 
            this.idinsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.idinsert.Location = new System.Drawing.Point(175, 158);
            this.idinsert.Name = "idinsert";
            this.idinsert.Size = new System.Drawing.Size(187, 31);
            this.idinsert.TabIndex = 8;
            // 
            // Nameinsert
            // 
            this.Nameinsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Nameinsert.Location = new System.Drawing.Point(175, 204);
            this.Nameinsert.Name = "Nameinsert";
            this.Nameinsert.Size = new System.Drawing.Size(187, 31);
            this.Nameinsert.TabIndex = 9;
            // 
            // desinsert
            // 
            this.desinsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.desinsert.Location = new System.Drawing.Point(175, 256);
            this.desinsert.Name = "desinsert";
            this.desinsert.Size = new System.Drawing.Size(187, 31);
            this.desinsert.TabIndex = 10;
            // 
            // pTECPOSDataSet
            // 
            this.pTECPOSDataSet.DataSetName = "PTECPOSDataSet";
            this.pTECPOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cagetorytblBindingSource
            // 
            this.cagetorytblBindingSource.DataMember = "Cagetorytbl";
            this.cagetorytblBindingSource.DataSource = this.pTECPOSDataSet;
            // 
            // cagetorytblTableAdapter
            // 
            this.cagetorytblTableAdapter.ClearBeforeFill = true;
            // 
            // testingbox
            // 
            this.testingbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.testingbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.testingbox.Location = new System.Drawing.Point(89, 562);
            this.testingbox.Name = "testingbox";
            this.testingbox.ReadOnly = true;
            this.testingbox.Size = new System.Drawing.Size(215, 29);
            this.testingbox.TabIndex = 12;
            // 
            // ptecposDataSet1
            // 
            this.ptecposDataSet1.DataSetName = "PTECPOSDataSet";
            this.ptecposDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CatData
            // 
            this.CatData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatData.Location = new System.Drawing.Point(465, 119);
            this.CatData.Name = "CatData";
            this.CatData.ReadOnly = true;
            this.CatData.Size = new System.Drawing.Size(741, 472);
            this.CatData.TabIndex = 13;
            this.CatData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatData_CellContentClick);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1241, 803);
            this.Controls.Add(this.CatData);
            this.Controls.Add(this.testingbox);
            this.Controls.Add(this.desinsert);
            this.Controls.Add(this.Nameinsert);
            this.Controls.Add(this.idinsert);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memcage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Member";
            this.Text = "Member";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pTECPOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cagetorytblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptecposDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memcage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox idinsert;
        private System.Windows.Forms.TextBox Nameinsert;
        private System.Windows.Forms.TextBox desinsert;
        private PTECPOSDataSet pTECPOSDataSet;
        private System.Windows.Forms.BindingSource cagetorytblBindingSource;
        private PTECPOSDataSetTableAdapters.CagetorytblTableAdapter cagetorytblTableAdapter;
        private System.Windows.Forms.TextBox testingbox;
        private PTECPOSDataSet ptecposDataSet1;
        private System.Windows.Forms.DataGridView CatData;
    }
}