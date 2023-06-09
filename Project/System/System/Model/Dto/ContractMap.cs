﻿using AutoMapper;
using Server.Model.Entity;

namespace Server.Model.Dto
{
    public class ContractMap : Profile
    {
        public ContractMap()
        {
            CreateMap<Contract, ContractDto>();

            CreateMap<ContractDto, Contract>();
        }
    }

    public class ContractIDDto
    {
        public string ContractID { get; set; }
        public string SupplierID { get; set; }
        public string ContractType { get; set; }
    }

    public class ContractDto
    {
        public string ContractID { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime ExpireTime { get; set; }
        public string ContractType { get; set; }
        public string SupplierID { get; set; }
        public string? StaffID { get; set; }
        public int? RepeatDate { get; set; }
        public string refsupNum { get; set; }
    }

    public class ContractDtoWithItem
    {
        public ContractDto Contract { get; set; }
        public List<ContractDtoItem>? items { get; set; }
    }

    public class ContractDtoItem
    {
        public string itemID { get; set; }
        public string? name { get; set; }
        public double? price { get; set; }
        public double quantity { get; set; }
        public string? CategoryID { get; set; }
        public double? MOQ { get; set; }
    }
}
