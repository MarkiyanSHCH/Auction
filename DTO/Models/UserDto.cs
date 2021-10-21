using Domain.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [Column(TypeName = "Date")]
        public DateTime RowInsertTime { get; set; }
        [Column(TypeName = "Date")]
        public DateTime RowUpdateTime { get; set; }


        public User MapTo()
            => new User
            {
                Id = this.Id,
                Name = this.Name,
                Role = this.Role,
                Login = this.Login,
                Password = this.Password,
                RowInsertTime = this.RowInsertTime,
                RowUpdateTime = this.RowUpdateTime
            };
        public static UserDto MapBack(User tmp)
            => new UserDto
            {
                Id = tmp.Id,
                Name = tmp.Name,
                Role = tmp.Role,
                Login = tmp.Login,
                Password = tmp.Password,
                RowInsertTime = tmp.RowInsertTime,
                RowUpdateTime = tmp.RowUpdateTime
            };
    }
}
