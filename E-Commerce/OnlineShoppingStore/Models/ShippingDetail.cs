﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.Models
{
    public class ShippingDetail
    {
        public int ShippingDetailId { get; set; }

        [Required]
        public int? MemberId { get; set; }

        [Required]
        public string Adress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }

        [Required]
        public string ZipCode { get; set; }

        public int? OrderId { get; set; }

        public decimal? AmountPaid { get; set; }

        [Required]
        public string PaymentType { get; set; }
    }
}