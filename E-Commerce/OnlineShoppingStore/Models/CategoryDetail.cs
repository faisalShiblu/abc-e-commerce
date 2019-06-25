using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category Name Requird")]
        [StringLength(100, ErrorMessage = "Minimum 3 and minimum 5 and maximum 100 charaters are allowed", MinimumLength = 3)]
        public string CategoryName { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDelete { get; set; }
    }
}