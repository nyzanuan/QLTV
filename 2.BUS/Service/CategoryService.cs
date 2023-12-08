using _1.DAL.IRepository;
using _1.DAL.Model;
using _1.DAL.Repository;
using _2.BUS.IService;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }

        public bool AddCategory(Category category)
        {
            return _categoryRepository.AddCategory(category);
        }

        public bool DeleteCategory(int id)
        {
            return _categoryRepository.DeleteCategory(id);
        }

        public ValueReturn GetAllCategory(int pageIndex, int pageSize, string? search)
        {
            try
            {
                ValueReturn result = _categoryRepository.GetAllCategory(pageIndex, pageSize, search);
                return result;
            }
            catch (Exception ex)
            {
                return new ValueReturn()
                {
                    Message = ex.Message,
                    Status = false,
                    Value = new DataReturn
                    {
                        TotalElemnent = 0,
                        ListElemnent = Array.Empty<Category>(),
                    }

                };
            }
        }

        public Category GetCategory(int id)
        {
            return _categoryRepository.GetCategory(id);
        }

        public bool UpdateCategory(Category category)
        {
            return _categoryRepository.UpdateCategory(category);
        }
    }
}
