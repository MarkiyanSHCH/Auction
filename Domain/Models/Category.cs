using System;

namespace Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }
    }
}
