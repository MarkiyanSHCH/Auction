using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Photo { get; set; }
        public double? FixPrice { get; set; }
        public double? AuctionPrice { get; set; }
        public bool? Sell {  get; set; }
        public DateTime? StartDate {  get; set; }
        public DateTime? EndDate {  get; set; }
        public int? CategoryId {  get; set; }
        public int? UserId {  get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }

    }
}
