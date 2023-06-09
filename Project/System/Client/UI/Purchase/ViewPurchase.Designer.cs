﻿namespace Client.UI.Purchase
{
    partial class ViewPurchase
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
            this.label1 = new System.Windows.Forms.Label();
            this.siSearchBox = new System.Windows.Forms.TextBox();
            this.SupGridView = new System.Windows.Forms.DataGridView();
            this.existCheckGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupNameDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDetailBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.viewHistBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SupGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            // 
            // siSearchBox
            // 
            this.siSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siSearchBox.Location = new System.Drawing.Point(132, 27);
            this.siSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.siSearchBox.Name = "siSearchBox";
            this.siSearchBox.Size = new System.Drawing.Size(125, 30);
            this.siSearchBox.TabIndex = 6;
            // 
            // SupGridView
            // 
            this.SupGridView.AllowUserToAddRows = false;
            this.SupGridView.AllowUserToDeleteRows = false;
            this.SupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.existCheckGV,
            this.gvSupplierID,
            this.SupNameDataGrid,
            this.gvDetailBtn});
            this.SupGridView.Location = new System.Drawing.Point(36, 71);
            this.SupGridView.Margin = new System.Windows.Forms.Padding(2);
            this.SupGridView.Name = "SupGridView";
            this.SupGridView.RowHeadersWidth = 62;
            this.SupGridView.RowTemplate.Height = 28;
            this.SupGridView.Size = new System.Drawing.Size(909, 402);
            this.SupGridView.TabIndex = 8;
            this.SupGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupGridView_CellContentClick);
            // 
            // existCheckGV
            // 
            this.existCheckGV.HeaderText = "Exist";
            this.existCheckGV.Name = "existCheckGV";
            this.existCheckGV.ReadOnly = true;
            // 
            // gvSupplierID
            // 
            this.gvSupplierID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSupplierID.HeaderText = "Supplier ID";
            this.gvSupplierID.MinimumWidth = 8;
            this.gvSupplierID.Name = "gvSupplierID";
            this.gvSupplierID.ReadOnly = true;
            this.gvSupplierID.Width = 84;
            // 
            // SupNameDataGrid
            // 
            this.SupNameDataGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupNameDataGrid.HeaderText = "Supplier Name";
            this.SupNameDataGrid.Name = "SupNameDataGrid";
            this.SupNameDataGrid.ReadOnly = true;
            // 
            // gvDetailBtn
            // 
            this.gvDetailBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvDetailBtn.HeaderText = "Detail";
            this.gvDetailBtn.MinimumWidth = 8;
            this.gvDetailBtn.Name = "gvDetailBtn";
            this.gvDetailBtn.ReadOnly = true;
            this.gvDetailBtn.Text = "Detail";
            this.gvDetailBtn.Width = 40;
            // 
            // viewHistBtn
            // 
            this.viewHistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewHistBtn.Location = new System.Drawing.Point(786, 15);
            this.viewHistBtn.Name = "viewHistBtn";
            this.viewHistBtn.Size = new System.Drawing.Size(159, 45);
            this.viewHistBtn.TabIndex = 9;
            this.viewHistBtn.Text = "View History";
            this.viewHistBtn.UseVisualStyleBackColor = true;
            this.viewHistBtn.Click += new System.EventHandler(this.viewHistBtn_Click);
            // 
            // ViewPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 545);
            this.Controls.Add(this.viewHistBtn);
            this.Controls.Add(this.SupGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siSearchBox);
            this.Name = "ViewPurchase";
            this.Text = "ViewPurchase";
            ((System.ComponentModel.ISupportInitialize)(this.SupGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox siSearchBox;
        private System.Windows.Forms.DataGridView SupGridView;
        private System.Windows.Forms.Button viewHistBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn existCheckGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupNameDataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn gvDetailBtn;
    }
}