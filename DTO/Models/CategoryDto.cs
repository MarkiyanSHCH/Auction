using Domain.Models;
using System;

namespace DTO.Models
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }

        public Category MapTo()
            => new Category
            {
                Id = this.Id,
                Name = this.Name,
                RowInsertTime= this.RowInsertTime,
                RowUpdateTime= this.RowUpdateTime
            };

        public static CategoryDto MapBack(Category tmp)
            => new CategoryDto
            {
                Id = tmp.Id,
                Name = tmp.Name,
                RowInsertTime = tmp.RowInsertTime,
                RowUpdateTime = tmp.RowUpdateTime
            };
    }
}
