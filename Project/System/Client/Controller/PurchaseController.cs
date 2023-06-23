﻿using Client.Helper;
using Client.Model.Receive;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Controller
{
    public class PurchaseController
    {
        public async Task<List<SupplierModel>> getSupplier()
        {
            var request = new RestRequest("/api/purchase")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<List<SupplierModel>>(respone.Content);
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return null;
        }
        public async Task<List<PurchaseItemModel>> getItem(string supID)
        {
            var request = new RestRequest("/api/purchase/" + supID)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<List<PurchaseItemModel>>(respone.Content);
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return null;
        }

        public async Task<List<BpaListModel>> getBPA(string supID)
        {
            var request = new RestRequest("/api/purchase/bpa/" + supID)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<List<BpaListModel>>(respone.Content);
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return null;
        }

        public async Task<String> getNewpID(string supID)
        {
            var request = new RestRequest("/api/purchase/bpa/new/" + supID)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<string>(respone.Content);
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return null;
        }

        public async Task<bool> CreateNewPurchase(string jsonData,string pid, byte[] pdf)
        {
            var request = new RestRequest("/api/purchase/", Method.Post)
                .AddHeader("Authorization", GlobalData.UserInfo.Token)
                .AddParameter("PurchaseData", jsonData, ParameterType.RequestBody)
                .AddFile("files", pdf, pid + ".pdf", "application/pdf");

            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public async Task<List<PurchaseRecord>> getRecord()
        {
            var request = new RestRequest("/api/purchase/record")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<List<PurchaseRecord>>(respone.Content);
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return null;
        }

        public async Task<History> getRecordbyID(string pid)
        {
            var request = new RestRequest("/api/purchase/record/" + pid)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<History> (respone.Content);
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return null;
        }

        public async void GetDocs(string pid)
        {
            var request = new RestRequest("/api/purchase/record/" + pid + "/Docs")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var response = await ApiClient.client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveDialog.DefaultExt = "pdf";
                    saveDialog.FileName = pid + ".pdf";
                    saveDialog.AddExtension = true;
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveDialog.FileName;
                        System.IO.File.WriteAllBytes(filePath, response.RawBytes);
                        MessageBox.Show("File downloaded successfully!");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
