namespace FinalShoeStore
{
    partial class FetchProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FetchProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.prologout = new System.Windows.Forms.Button();
            this.pro_fetch_show = new System.Windows.Forms.Button();
            this.pro_upd_show = new System.Windows.Forms.Button();
            this.pro_add_show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pro_gridview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productDBDataSet = new FinalShoeStore.ProductDBDataSet();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productTableAdapter = new FinalShoeStore.ProductDBDataSetTableAdapters.productTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pro_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.prologout);
            this.panel1.Controls.Add(this.pro_fetch_show);
            this.panel1.Controls.Add(this.pro_upd_show);
            this.panel1.Controls.Add(this.pro_add_show);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 786);
            this.panel1.TabIndex = 5;
            // 
            // prologout
            // 
            this.prologout.Font = new System.Drawing.Font("Vermin Vibes 2 Soft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prologout.Location = new System.Drawing.Point(40, 695);
            this.prologout.Name = "prologout";
            this.prologout.Size = new System.Drawing.Size(189, 67);
            this.prologout.TabIndex = 10;
            this.prologout.Text = "LOGOUT";
            this.prologout.UseVisualStyleBackColor = true;
            this.prologout.Click += new System.EventHandler(this.Prologout_Click);
            // 
            // pro_fetch_show
            // 
            this.pro_fetch_show.BackColor = System.Drawing.Color.White;
            this.pro_fetch_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pro_fetch_show.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_fetch_show.Location = new System.Drawing.Point(40, 508);
            this.pro_fetch_show.Name = "pro_fetch_show";
            this.pro_fetch_show.Size = new System.Drawing.Size(189, 67);
            this.pro_fetch_show.TabIndex = 9;
            this.pro_fetch_show.Text = "FETCH";
            this.pro_fetch_show.UseVisualStyleBackColor = false;
            // 
            // pro_upd_show
            // 
            this.pro_upd_show.BackColor = System.Drawing.Color.Silver;
            this.pro_upd_show.FlatAppearance.BorderSize = 0;
            this.pro_upd_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pro_upd_show.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_upd_show.Location = new System.Drawing.Point(40, 400);
            this.pro_upd_show.Name = "pro_upd_show";
            this.pro_upd_show.Size = new System.Drawing.Size(189, 67);
            this.pro_upd_show.TabIndex = 8;
            this.pro_upd_show.Text = "UPDATE";
            this.pro_upd_show.UseVisualStyleBackColor = false;
            this.pro_upd_show.Click += new System.EventHandler(this.Pro_upd_show_Click);
            // 
            // pro_add_show
            // 
            this.pro_add_show.BackColor = System.Drawing.Color.Silver;
            this.pro_add_show.FlatAppearance.BorderSize = 0;
            this.pro_add_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pro_add_show.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_add_show.Location = new System.Drawing.Point(40, 288);
            this.pro_add_show.Name = "pro_add_show";
            this.pro_add_show.Size = new System.Drawing.Size(189, 67);
            this.pro_add_show.TabIndex = 7;
            this.pro_add_show.Text = "ADD";
            this.pro_add_show.UseVisualStyleBackColor = false;
            this.pro_add_show.Click += new System.EventHandler(this.Pro_add_show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vermin Vibes 2 Soft", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Warehouse";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.pro_gridview);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(304, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 749);
            this.panel2.TabIndex = 6;
            // 
            // pro_gridview
            // 
            this.pro_gridview.AllowUserToOrderColumns = true;
            this.pro_gridview.AutoGenerateColumns = false;
            this.pro_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pro_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pro_gridview.DataSource = this.bindingSource1;
            this.pro_gridview.Location = new System.Drawing.Point(45, 118);
            this.pro_gridview.Name = "pro_gridview";
            this.pro_gridview.Size = new System.Drawing.Size(831, 573);
            this.pro_gridview.TabIndex = 19;
            this.pro_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pro_gridview_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn3.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "product";
            this.bindingSource1.DataSource = this.productDBDataSet;
            // 
            // productDBDataSet
            // 
            this.productDBDataSet.DataSetName = "ProductDBDataSet";
            this.productDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vermin Vibes 2 Soft", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fetch Product";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // FetchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1280, 786);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FetchProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FetchProduct";
            this.Load += new System.EventHandler(this.FetchProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pro_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button prologout;
        private System.Windows.Forms.Button pro_fetch_show;
        private System.Windows.Forms.Button pro_upd_show;
        private System.Windows.Forms.Button pro_add_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView pro_gridview;
        private ProductDBDataSet productDBDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ProductDBDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}