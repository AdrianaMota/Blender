﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Blender.Models
{
    public class ProductColor
    {
        public string HexValue { get; set; }
        public string ColourName { get; set; }
    }

    public class MakeupInfo
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string PriceSign { get; set; }
        public string Currency { get; set; }
        public string ImageLink { get; set; }
        public string ProductLink { get; set; }
        public string WebsiteLink { get; set; }
        public string Description { get; set; }
        public double? Rating { get; set; }
        public string Category { get; set; }
        public string ProductType { get; set; }
        public IList<string> TagList { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ProductApiUrl { get; set; }
        public string ApiFeaturedImage { get; set; }
        public IList<ProductColor> ProductColors { get; set; }
    }
}

