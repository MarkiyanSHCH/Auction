using System;

namespace Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }
    }
}
