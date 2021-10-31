using BLL.Interface;
using DAL.Interface;
using Domain.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class CategoryServices: ICategoryServices
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryServices(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public List<Category> GetAllCategory()
            => this._categoryRepository.GetAll();
        public Category GetById(int id)
            => this._categoryRepository.Get(id);

    }
}
