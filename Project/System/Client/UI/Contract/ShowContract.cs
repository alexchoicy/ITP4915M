﻿using Client.Model.Receive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.UI.Contract;

namespace Client.UI.Agreement
{
    public partial class ShowContract : Form
    {
        private ContractController contractController = new ContractController();
        private Main mainForm;
        public ShowContract(Main mainForm)
        {
            InitializeComponent();
            //InitializeContractDataView();
            this.mainForm = mainForm;
            LoadData();
        }

        private void InitializeContractDataView()
        {

            ContractDataView.Columns.Add("ContractID", "Contract ID");
            ContractDataView.Columns.Add("SignDate", "Sign Date");
            ContractDataView.Columns.Add("ExpireTime", "Expire Time");
            ContractDataView.Columns.Add("ContractType", "Contract Type");
            ContractDataView.Columns.Add("SupplierID", "Supplier ID");
            ContractDataView.Columns.Add("StaffID", "Staff ID");
        }
        private async void LoadData()
        {
            var data = await GetAllContract();
            if (data == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            PopulateContractDataView(data);
        }
        private async Task<List<ContractModel>> GetAllContract()
        {
            var contract = await contractController.getAll();
            return contract;
        }
        private void PopulateContractDataView(List<ContractModel> contracts)
        {
            ContractDataView.AutoGenerateColumns = false;
            BindDataView(contracts);
        }

        private void BindDataView(List<ContractModel> contracts)
        {
            foreach (var data in contracts)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(ContractDataView,
                    data.ContractID,
                    data.SignDate.ToString("dd/MM/yyyy"),
                    data.ExpireTime.ToString("dd/MM/yyyy"),
                    data.ContractType,
                    data.SupplierID,
                    data.StaffID);
                ContractDataView.Rows.Add(row);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Check if the close reason is the user clicking the close button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                mainForm.Show();
            }
        }

        private void createContractBtn_Click(object sender, EventArgs e)
        {
            var CreateForm = new CreateContract();
            var state = CreateForm.ShowDialog();
            if (state == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void ContractDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ContractID = ContractDataView.Rows[e.RowIndex].Cells["ContractID"].Value.ToString();

            Form conDetail = new ContractDetail(ContractID);
            conDetail.ShowDialog();


        }
    }
}