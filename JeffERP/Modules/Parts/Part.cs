using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DynamicMVC.Annotations;

namespace JeffERP.Models
{
    [DynamicEntity]
    public class Part
    {
        public int Id { get; set; }
        [Required]
        public string PartNumber { get; set; }
        [Required]
        public string Description { get; set; }

    }
}