﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductManagement.DataConnector
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Product
    {
        [DisplayName("Mã sản phẩm")]
        public string MaSp { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string TenSp { get; set; }
        [DisplayName("Số lượng")]
        public Nullable<long> SoLuong { get; set; }
        [DisplayName("Đơn giá")]
        public Nullable<long> DonGia { get; set; }
        [DisplayName("Xuất xứ")]
        public string XuatXu { get; set; }
        [DisplayName("Ngày hết hạn")]
        public Nullable<System.DateTime> NgayHetHan { get; set; }
    }
}
