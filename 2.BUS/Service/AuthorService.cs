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
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorService() {
            _authorRepository = new AuthorRepository();
        }

        public bool AddAuthor(Author newTacgia)
        {
            return _authorRepository.AddAuthor(newTacgia);
        }

        public bool DeleteAuthor(int maTacGia)
        {
            return _authorRepository.DeleteAuthor(maTacGia);
        }

        public ValueReturn GetAllAuthor(int pageIndex, int pageSize, string? search)
        {
            try
            {
                ValueReturn result = _authorRepository.GetAllAuthor(pageIndex, pageSize, search);
                return result;
            }catch (Exception ex)
            {
                return new ValueReturn()
                {
                    Message = ex.Message,
                    Status = false,
                    Value = new DataReturn
                    {
                        TotalElemnent = 0,
                        ListElemnent = Array.Empty<Author>(),
                    }
                    
                };
            }
        }

        public bool UpdateAuthor(Author author)
        {
            return _authorRepository.UpdateAuthor(author);

        }
    }
}
