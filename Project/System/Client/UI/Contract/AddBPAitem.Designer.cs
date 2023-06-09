﻿namespace Client.UI.Contract
{
    partial class AddBPAitem
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
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acAddItemViewGrid = new System.Windows.Forms.DataGridView();
            this.addItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acRmBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.acAddBtn = new System.Windows.Forms.Button();
            this.acQtyTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.acCancelBtn = new System.Windows.Forms.Button();
            this.acSubmitBtn = new System.Windows.Forms.Button();
            this.acItemTxt = new System.Windows.Forms.ComboBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acAddItemViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.AllowUserToDeleteRows = false;
            this.itemDataGridView.AllowUserToOrderColumns = true;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.itemName});
            this.itemDataGridView.Location = new System.Drawing.Point(29, 324);
            this.itemDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowHeadersWidth = 62;
            this.itemDataGridView.RowTemplate.Height = 28;
            this.itemDataGridView.Size = new System.Drawing.Size(746, 190);
            this.itemDataGridView.TabIndex = 0;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.MinimumWidth = 8;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Width = 150;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.HeaderText = "ItemName";
            this.itemName.MinimumWidth = 8;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // acAddItemViewGrid
            // 
            this.acAddItemViewGrid.AllowUserToAddRows = false;
            this.acAddItemViewGrid.AllowUserToDeleteRows = false;
            this.acAddItemViewGrid.AllowUserToOrderColumns = true;
            this.acAddItemViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acAddItemViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addItemID,
            this.AddItemName,
            this.priceDataView,
            this.addqty,
            this.acRmBtn});
            this.acAddItemViewGrid.Location = new System.Drawing.Point(29, 20);
            this.acAddItemViewGrid.Margin = new System.Windows.Forms.Padding(2);
            this.acAddItemViewGrid.Name = "acAddItemViewGrid";
            this.acAddItemViewGrid.RowHeadersWidth = 62;
            this.acAddItemViewGrid.RowTemplate.Height = 28;
            this.acAddItemViewGrid.Size = new System.Drawing.Size(746, 148);
            this.acAddItemViewGrid.TabIndex = 1;
            this.acAddItemViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.acAddItemViewGrid_CellContentClick);
            // 
            // addItemID
            // 
            this.addItemID.HeaderText = "Item ID";
            this.addItemID.MinimumWidth = 8;
            this.addItemID.Name = "addItemID";
            this.addItemID.ReadOnly = true;
            this.addItemID.Width = 150;
            // 
            // AddItemName
            // 
            this.AddItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AddItemName.HeaderText = "Item Name";
            this.AddItemName.MinimumWidth = 8;
            this.AddItemName.Name = "AddItemName";
            this.AddItemName.ReadOnly = true;
            this.AddItemName.Width = 77;
            // 
            // priceDataView
            // 
            this.priceDataView.HeaderText = "Price";
            this.priceDataView.MinimumWidth = 8;
            this.priceDataView.Name = "priceDataView";
            this.priceDataView.ReadOnly = true;
            this.priceDataView.Width = 150;
            // 
            // addqty
            // 
            this.addqty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.addqty.HeaderText = "Minimum Order Quantity";
            this.addqty.MinimumWidth = 8;
            this.addqty.Name = "addqty";
            this.addqty.Width = 132;
            // 
            // acRmBtn
            // 
            this.acRmBtn.HeaderText = "Remove";
            this.acRmBtn.MinimumWidth = 8;
            this.acRmBtn.Name = "acRmBtn";
            this.acRmBtn.ReadOnly = true;
            this.acRmBtn.Text = "Remove";
            this.acRmBtn.UseColumnTextForButtonValue = true;
            this.acRmBtn.Width = 150;
            // 
            // acAddBtn
            // 
            this.acAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acAddBtn.Location = new System.Drawing.Point(647, 185);
            this.acAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.acAddBtn.Name = "acAddBtn";
            this.acAddBtn.Size = new System.Drawing.Size(128, 60);
            this.acAddBtn.TabIndex = 3;
            this.acAddBtn.Text = "Add";
            this.acAddBtn.UseVisualStyleBackColor = true;
            this.acAddBtn.Click += new System.EventHandler(this.acAddBtn_Click);
            // 
            // acQtyTxt
            // 
            this.acQtyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acQtyTxt.Location = new System.Drawing.Point(412, 212);
            this.acQtyTxt.Margin = new System.Windows.Forms.Padding(2);
            this.acQtyTxt.Name = "acQtyTxt";
            this.acQtyTxt.Size = new System.Drawing.Size(131, 30);
            this.acQtyTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minimum Order Quantity";
            // 
            // acCancelBtn
            // 
            this.acCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acCancelBtn.Location = new System.Drawing.Point(477, 562);
            this.acCancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.acCancelBtn.Name = "acCancelBtn";
            this.acCancelBtn.Size = new System.Drawing.Size(140, 70);
            this.acCancelBtn.TabIndex = 8;
            this.acCancelBtn.Text = "Cancel";
            this.acCancelBtn.UseVisualStyleBackColor = true;
            this.acCancelBtn.Click += new System.EventHandler(this.acCancelBtn_Click);
            // 
            // acSubmitBtn
            // 
            this.acSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acSubmitBtn.Location = new System.Drawing.Point(636, 562);
            this.acSubmitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.acSubmitBtn.Name = "acSubmitBtn";
            this.acSubmitBtn.Size = new System.Drawing.Size(140, 70);
            this.acSubmitBtn.TabIndex = 9;
            this.acSubmitBtn.Text = "Sumbit";
            this.acSubmitBtn.UseVisualStyleBackColor = true;
            this.acSubmitBtn.Click += new System.EventHandler(this.acSubmitBtn_Click);
            // 
            // acItemTxt
            // 
            this.acItemTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acItemTxt.FormattingEnabled = true;
            this.acItemTxt.Location = new System.Drawing.Point(38, 213);
            this.acItemTxt.Name = "acItemTxt";
            this.acItemTxt.Size = new System.Drawing.Size(180, 33);
            this.acItemTxt.TabIndex = 10;
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(29, 289);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(189, 30);
            this.searchTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(239, 212);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(2);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(131, 30);
            this.priceTxt.TabIndex = 13;
            // 
            // AddBPAitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 645);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.acItemTxt);
            this.Controls.Add(this.acSubmitBtn);
            this.Controls.Add(this.acCancelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acQtyTxt);
            this.Controls.Add(this.acAddBtn);
            this.Controls.Add(this.acAddItemViewGrid);
            this.Controls.Add(this.itemDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddBPAitem";
            this.Text = "AddContractItem";
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acAddItemViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.DataGridView acAddItemViewGrid;
        private System.Windows.Forms.Button acAddBtn;
        private System.Windows.Forms.TextBox acQtyTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button acCancelBtn;
        private System.Windows.Forms.Button acSubmitBtn;
        private System.Windows.Forms.ComboBox acItemTxt;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn addItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn addqty;
        private System.Windows.Forms.DataGridViewButtonColumn acRmBtn;
    }
}