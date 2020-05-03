namespace Sales.Common.Models
    //preferible using dentro del namespace para evitar warnings
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductId { get; set;}

        [Required]
        public string Description { get; set; }

        public Decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime Publish { get; set; }
    }
}

