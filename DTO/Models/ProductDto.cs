using System;
using System.ComponentModel.DataAnnotations.Schema;

using Domain.Models;

namespace DTO.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Photo { get; set; }
        public double? FixPrice { get; set; }
        public double? AuctionPrice { get; set; }
        public bool? Sell { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? EndDate { get; set; }
        public int CategoryId { get; set; }
        public int? UserId { get; set; }
        [Column(TypeName = "Date")]
        public DateTime RowInsertTime { get; set; }
        [Column(TypeName = "Date")]
        public DateTime RowUpdateTime { get; set; }


        public Product MapTo()
            => new Product
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description,
                Photo = this.Photo,
                FixPrice = this.FixPrice,
                AuctionPrice = this.AuctionPrice,
                Sell = this.Sell,
                StartDate = this.StartDate,
                EndDate = this.EndDate,
                CategoryId = this.CategoryId,
                UserId = this.UserId,
                RowInsertTime = this.RowInsertTime,
                RowUpdateTime = this.RowUpdateTime
            };

        public static ProductDto MapBack(Product tmp)
            => new ProductDto
            {
                Id = tmp.Id,
                Name = tmp.Name,
                Description = tmp.Description,
                Photo = tmp.Photo,
                FixPrice = tmp.FixPrice,
                AuctionPrice = tmp.AuctionPrice,
                Sell = tmp.Sell,
                StartDate = tmp.StartDate,
                EndDate = tmp.EndDate,
                CategoryId = tmp.CategoryId,
                UserId = tmp.UserId,
                RowInsertTime = tmp.RowInsertTime,
                RowUpdateTime = tmp.RowUpdateTime
            };
    }

}
