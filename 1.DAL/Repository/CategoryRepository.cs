using _1.DAL.Data;
using _1.DAL.IRepository;
using _1.DAL.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly DataContext _dataContext;
        public CategoryRepository()
        {
            _dataContext = new DataContext();
        }
        public bool SaveData()
        {
            var result = _dataContext.SaveChanges() > 0;
            return result;
        }
        public bool AddCategory(Category category)
        {
            try
            {
                _dataContext.Category.Add(category);
                return SaveData();
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteCategory(int id)
        {
            try
            {
                
                var category = _dataContext.Category.FirstOrDefault(p => p.CategoryId == id);
                _dataContext.Category.Remove(category);
                return SaveData();
            }
            catch
            {
                return false;
            }
        }

        public ValueReturn GetAllCategory(int pageIndex, int pageSize, string? search)
        {
            try
            {
                var query = _dataContext.Category.AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    string searchWithoutDiacritics = search.ToLower();
                    query = query.Where(p =>
                        p.Name.ToLower().Contains(searchWithoutDiacritics)
                    );
                }
                return new ValueReturn()
                {
                    Status = true,
                    Value = new DataReturn()
                    {
                        ListElemnent = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList(),
                        TotalElemnent = query.Count()
                    }

                };
            }
            catch (Exception ex)
            {
                return new ValueReturn()
                {
                    Message = ex.Message,
                    Status = false,
                    Value = new DataReturn()
                    {
                        ListElemnent = Array.Empty<Category>(),
                        TotalElemnent = 0

                    }
                };
            }
        }

        public Category GetCategory(int id)
        {
            Category category = _dataContext.Category.FirstOrDefault(p => p.CategoryId == id);
            if (category != null)
                return category;
            else
                return new Category();
        }

        public bool UpdateCategory(Category category)
        {
            try
            {
                var cateData = _dataContext.Category.FirstOrDefault(p => p.CategoryId == category.CategoryId);
                if (cateData != null)
                {
                    cateData.Name = category.Name;
                    cateData.Image = category.Image;
                    return SaveData();
                }
                else
                {
                    return false;
                }
            }

            catch { return false; }
        }
    }
}
