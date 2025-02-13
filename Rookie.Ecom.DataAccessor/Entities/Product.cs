﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class Product : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Desc { get; set; }

        [StringLength(maximumLength: 250)]
        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public decimal? Cost { get; set; }

        public bool IsFeatured { get; set; }

        public Guid? CategoryId { get; set; }

        public Category Category { get; set; }

        public Guid? PublisherId { get; set; }

        public Publisher Publisher { get; set; }

        public Guid? AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
