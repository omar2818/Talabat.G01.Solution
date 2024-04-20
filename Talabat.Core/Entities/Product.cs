﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.Core.Entities
{
	public class Product : BaseEntity
	{
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }

        public int BrandId { get; set; } // Foreign Key Column

        public ProductBrand Brand { get; set; } // Navigational Property

        public int CategoryId { get; set; }

        public ProductCategory Category { get; set; }
    }
}
