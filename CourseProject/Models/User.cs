﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name {  get; set; } 
        public string Role { get; set; }
        public string Login {  get; set; }
        public string Password {  get; set; }
    }
}
