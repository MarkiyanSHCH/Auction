using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface ICategoryServices
    {
        List<Category> GetAllCategory();
        Category GetById(int id);
    }
}
