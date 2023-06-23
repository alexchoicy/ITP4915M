﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Receive
{
    public class PurchaseItemModel
    {
        public string itemID { get; set; }
        public string itemName { get; set; }
        public double itemQty { get; set; }
    }
    public class BpaListModel
    {
        public int ID { get; set; }
        public string refsupNum { get; set; }
        public string ContractID { get; set; }
        public List<BpaItemListModel> items { get; set; }
    }
    public class BpaItemListModel
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string unit { get; set; }
        public double price { get; set; }
        public double MOQ { get; set; }
        public string refSupID { get; set; }
    }


    public class History
    {
        public PurchaseRecord record { get; set; }
        public List<PurchaseitemRecord> items { get; set; }
    }
    public class PurchaseRecord
    {
        public string pid { get; set; }
        public string Type { get; set; }
        public string refAggreNum { get; set; }
        public string supID { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
    }

    public class PurchaseitemRecord
    {
        public string itemID { get; set; }
        public string itemName { get; set; }
        public string UOM { get; set; }
        public double qty { get; set; }
        public double TotalPrice { get; set; }
    }

}
