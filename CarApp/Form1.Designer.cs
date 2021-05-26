namespace CarApp
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
            this.lsvCars = new System.Windows.Forms.ListView();
            this.regnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.make = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.forsale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxForSale = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtRegNr = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvCars
            // 
            this.lsvCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.regnr,
            this.make,
            this.model,
            this.year,
            this.forsale});
            this.lsvCars.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCars.Location = new System.Drawing.Point(23, 196);
            this.lsvCars.Name = "lsvCars";
            this.lsvCars.Size = new System.Drawing.Size(853, 302);
            this.lsvCars.TabIndex = 0;
            this.lsvCars.UseCompatibleStateImageBehavior = false;
            this.lsvCars.View = System.Windows.Forms.View.Details;
            this.lsvCars.SelectedIndexChanged += new System.EventHandler(this.lsvCars_SelectedIndexChanged);
            // 
            // regnr
            // 
            this.regnr.Text = "Reg Nr";
            this.regnr.Width = 81;
            // 
            // make
            // 
            this.make.Text = "Märke";
            this.make.Width = 83;
            // 
            // model
            // 
            this.model.Text = "Model";
            // 
            // year
            // 
            this.year.Text = "Year";
            // 
            // forsale
            // 
            this.forsale.Text = "Till Salu";
            this.forsale.Width = 77;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRegNr);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cbxForSale);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtMake);
            this.groupBox1.Location = new System.Drawing.Point(23, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(100, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 35);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Sök i biluppgifter.se";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdd.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(697, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxForSale
            // 
            this.cbxForSale.AutoSize = true;
            this.cbxForSale.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxForSale.Location = new System.Drawing.Point(697, 27);
            this.cbxForSale.Name = "cbxForSale";
            this.cbxForSale.Size = new System.Drawing.Size(100, 24);
            this.cbxForSale.TabIndex = 8;
            this.cbxForSale.Text = "Till Salu";
            this.cbxForSale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "År";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Märke";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reg Nr";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(420, 74);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(175, 26);
            this.txtYear.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(420, 25);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(175, 26);
            this.txtModel.TabIndex = 2;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(100, 74);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(175, 26);
            this.txtMake.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(23, 504);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(184, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Rensa bort all data";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRemove.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(684, 504);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(178, 30);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Ta bort markerad";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtRegNr
            // 
            this.txtRegNr.Location = new System.Drawing.Point(100, 25);
            this.txtRegNr.Name = "txtRegNr";
            this.txtRegNr.Size = new System.Drawing.Size(175, 26);
            this.txtRegNr.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(887, 557);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsvCars);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvCars;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader regnr;
        private System.Windows.Forms.ColumnHeader make;
        private System.Windows.Forms.ColumnHeader forsale;
        private System.Windows.Forms.CheckBox cbxForSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader model;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.TextBox txtRegNr;
    }
}

