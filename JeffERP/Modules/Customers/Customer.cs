using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DynamicMVC.Annotations;

namespace JeffERP.Models
{
    [DynamicEntity]
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}