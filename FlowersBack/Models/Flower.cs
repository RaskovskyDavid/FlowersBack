﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FlowersBack.Models
{
    public class Flower
    {
        [Key]
        public int FlowerId { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(50, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters", MinimumLength = 1)]
        [Index("Flower_Description_Index", IsUnique = true)]
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "You must enter a {0}")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Last purchase")]
        public DateTime? LastPurchase { get; set; }

        public String Image { get; set; }

        [Display(Name ="Is active")]
        public bool IsActive { get; set; }

        [DataType(DataType.MultilineText)]
        public String Observation { get; set; }
    }
}