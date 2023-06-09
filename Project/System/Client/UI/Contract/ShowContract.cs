﻿using Client.Model.Receive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Helper;
using Client.UI.Contract;

namespace Client.UI.Agreement
{
    public partial class ShowContract : Form
    {
        private List<ContractModel> data;
        private ContractController contractController = new ContractController();
        private Main mainForm;
        public ShowContract(Main mainForm)
        {
            InitializeComponent();
            //InitializeContractDataView();
            this.mainForm = mainForm;
            LoadData();
            searchTxt.TextChanged += searchTxt_TextChanged;
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
            data = await GetAllContract();
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
            ContractDataView.Rows.Clear();
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
                    data.StaffID,
                    "Detail");
                ContractDataView.Rows.Add(row);
            }
        }

        private void createContractBtn_Click(object sender, EventArgs e)
        {
            var CreateForm = new CreateContract(data);
            CreateForm.FormClosed += CreateForm_FormClosed;
            var state = CreateForm.ShowDialog();
            if (state == DialogResult.OK)
            {
                this.Show();
                LoadData();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContractDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 6)
                {
                    string ContractID = ContractDataView.Rows[e.RowIndex].Cells["ContractID"].Value.ToString();
                    string Type = ContractDataView.Rows[e.RowIndex].Cells["ContractType"].Value.ToString();
                    if(Type == "PC")
                    {
                        Form conDetail = new ContractDetail(ContractID);
                        conDetail.ShowDialog();
                    }
                    else if(Type == "BPA")
                    {
                        Form bpaForm = new BPADetail(ContractID);
                        bpaForm.ShowDialog();
                    }
                    else
                    {
                        Form conDetail = new ContractDetail(ContractID);
                        conDetail.ShowDialog();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return;
            }


        }
        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTxt.Text.Trim().ToLower();
            List<ContractModel> filteredContracts = data
                .Where(contract =>
                    contract.ContractID.ToLower().Contains(searchText) ||
                    contract.SupplierID.ToLower().Contains(searchText)||
                    contract.StaffID.ToLower().Contains(searchText))
                .ToList();
            PopulateContractDataView(filteredContracts);
        }
    }
}
