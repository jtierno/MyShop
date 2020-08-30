using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Core.Models
{
    public class ProductCategory
    {
        public string Id { get; set; }

        [StringLength(100)]
        [DisplayName("Category Name")]
        public string Category { get; set; }

        public string Description { get; set; }

        //Contructor
        public ProductCategory()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}