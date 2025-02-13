﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        public DateTime ApprovedDate { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Desc { get; set; }


        [StringLength(maximumLength: 250)]
        public string ImageUrl { get; set; }
    }
}
