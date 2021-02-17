﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static List<Product> MaintainanceTime;
        internal static string ProductsListed;

        public static string UnitPriceInvalid { get; internal set; }
    }
}
