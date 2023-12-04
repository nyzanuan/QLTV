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
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataContext _dataContext;
        public AuthorRepository()
        {
            _dataContext = new DataContext();
        }
        public ValueReturn GetAllAuthor(int pageIndex, int pageSize, string? search)
        {
            try
            {
                var query = _dataContext.Author.AsQueryable();
                if (search != null && search != "")
                {

                    query = query.Where(p=>p.Name.ToLower().Contains(search.ToLower()));

                }
                return new ValueReturn()
                {
                    Status = true,
                    Value = query.Skip((pageIndex-1)*pageSize).Take(pageSize).ToList(),
                };
            }
            catch (Exception ex)
            {
                return new ValueReturn()
                {
                    Message = ex.Message,
                    Status = false,
                    Value = Array.Empty<Author>()
                };
            }
        }
    }
}
