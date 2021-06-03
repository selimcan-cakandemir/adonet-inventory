
namespace CaseMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetSalesHistory = new System.Windows.Forms.Button();
            this.btnGetMostProfitable = new System.Windows.Forms.Button();
            this.btnBestSellingProductByQuantity = new System.Windows.Forms.Button();
            this.btnAddNewSales = new System.Windows.Forms.Button();
            this.btnDeleteSales = new System.Windows.Forms.Button();
            this.btnUpdateSales = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGetProfitsByCompany = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(736, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGetSalesHistory
            // 
            this.btnGetSalesHistory.Location = new System.Drawing.Point(12, 11);
            this.btnGetSalesHistory.Name = "btnGetSalesHistory";
            this.btnGetSalesHistory.Size = new System.Drawing.Size(155, 23);
            this.btnGetSalesHistory.TabIndex = 1;
            this.btnGetSalesHistory.Text = "Get all sales history";
            this.btnGetSalesHistory.UseVisualStyleBackColor = true;
            this.btnGetSalesHistory.Click += new System.EventHandler(this.btnGetSalesHistory_Click);
            // 
            // btnGetMostProfitable
            // 
            this.btnGetMostProfitable.Location = new System.Drawing.Point(12, 41);
            this.btnGetMostProfitable.Name = "btnGetMostProfitable";
            this.btnGetMostProfitable.Size = new System.Drawing.Size(155, 23);
            this.btnGetMostProfitable.TabIndex = 3;
            this.btnGetMostProfitable.Text = "Get most profitable store";
            this.btnGetMostProfitable.UseVisualStyleBackColor = true;
            this.btnGetMostProfitable.Click += new System.EventHandler(this.btnGetMostProfitable_Click);
            // 
            // btnBestSellingProductByQuantity
            // 
            this.btnBestSellingProductByQuantity.Location = new System.Drawing.Point(12, 71);
            this.btnBestSellingProductByQuantity.Name = "btnBestSellingProductByQuantity";
            this.btnBestSellingProductByQuantity.Size = new System.Drawing.Size(157, 23);
            this.btnBestSellingProductByQuantity.TabIndex = 4;
            this.btnBestSellingProductByQuantity.Text = "Best seller by quantity";
            this.btnBestSellingProductByQuantity.UseVisualStyleBackColor = true;
            this.btnBestSellingProductByQuantity.Click += new System.EventHandler(this.btnBestSellingProductByQuantity_Click);
            // 
            // btnAddNewSales
            // 
            this.btnAddNewSales.Location = new System.Drawing.Point(591, 343);
            this.btnAddNewSales.Name = "btnAddNewSales";
            this.btnAddNewSales.Size = new System.Drawing.Size(157, 23);
            this.btnAddNewSales.TabIndex = 5;
            this.btnAddNewSales.Text = "Add new sales history";
            this.btnAddNewSales.UseVisualStyleBackColor = true;
            this.btnAddNewSales.Click += new System.EventHandler(this.btnAddNewSales_Click);
            // 
            // btnDeleteSales
            // 
            this.btnDeleteSales.Location = new System.Drawing.Point(591, 372);
            this.btnDeleteSales.Name = "btnDeleteSales";
            this.btnDeleteSales.Size = new System.Drawing.Size(157, 23);
            this.btnDeleteSales.TabIndex = 5;
            this.btnDeleteSales.Text = "Delete sales history";
            this.btnDeleteSales.UseVisualStyleBackColor = true;
            this.btnDeleteSales.Click += new System.EventHandler(this.btnDeleteSales_Click);
            // 
            // btnUpdateSales
            // 
            this.btnUpdateSales.Location = new System.Drawing.Point(591, 401);
            this.btnUpdateSales.Name = "btnUpdateSales";
            this.btnUpdateSales.Size = new System.Drawing.Size(157, 23);
            this.btnUpdateSales.TabIndex = 5;
            this.btnUpdateSales.Text = "Update sales history";
            this.btnUpdateSales.UseVisualStyleBackColor = true;
            this.btnUpdateSales.Click += new System.EventHandler(this.btnUpdateSales_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(627, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // btnGetProfitsByCompany
            // 
            this.btnGetProfitsByCompany.Location = new System.Drawing.Point(459, 9);
            this.btnGetProfitsByCompany.Name = "btnGetProfitsByCompany";
            this.btnGetProfitsByCompany.Size = new System.Drawing.Size(162, 23);
            this.btnGetProfitsByCompany.TabIndex = 8;
            this.btnGetProfitsByCompany.Text = "Get profits by company";
            this.btnGetProfitsByCompany.UseVisualStyleBackColor = true;
            this.btnGetProfitsByCompany.Click += new System.EventHandler(this.btnGetProfitsByCompany_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(464, 322);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox2_MouseClick_1);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(464, 349);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox3_MouseClick);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(464, 376);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 9;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(464, 403);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Store";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantity sold";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current stock";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 437);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnGetProfitsByCompany);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUpdateSales);
            this.Controls.Add(this.btnDeleteSales);
            this.Controls.Add(this.btnAddNewSales);
            this.Controls.Add(this.btnBestSellingProductByQuantity);
            this.Controls.Add(this.btnGetMostProfitable);
            this.Controls.Add(this.btnGetSalesHistory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetSalesHistory;
        private System.Windows.Forms.Button btnGetMostProfitable;
        private System.Windows.Forms.Button btnBestSellingProductByQuantity;
        private System.Windows.Forms.Button btnAddNewSales;
        private System.Windows.Forms.Button btnDeleteSales;
        private System.Windows.Forms.Button btnUpdateSales;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGetProfitsByCompany;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

