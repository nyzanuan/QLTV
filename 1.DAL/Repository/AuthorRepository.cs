using _1.DAL.Data;
using _1.DAL.IRepository;
using _1.DAL.Model;
using Sharing.ReturnModel;
using BinaryAnalysis.UnidecodeSharp;


namespace _1.DAL.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataContext _dataContext;
        public AuthorRepository()
        {
            _dataContext = new DataContext();
        }

        public bool AddAuthor(Author newTacgia)
        {
            try
            {
                _dataContext.Author.Add(newTacgia);
                return SaveData();
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteAuthor(int maTacGia)
        {
            try
            {
                var author = _dataContext.Author.FirstOrDefault(p => p.AuthorId == maTacGia);
                _dataContext.Author.Remove(author);
                return SaveData();
            }
            catch
            {
                return false;
            }
        }

        public ValueReturn GetAllAuthor(int pageIndex, int pageSize, string? search)
        {
            try
            {
                var query = _dataContext.Author.AsQueryable();
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
                        ListElemnent = Array.Empty<Author>(),
                        TotalElemnent =0
                         
                    }
                };
            }
        }

        public bool SaveData()
        {
            var result = _dataContext.SaveChanges() > 0;
            return result ;
        }

        public bool UpdateAuthor(Author author)
        {
            try
            {
                var authorData = _dataContext.Author.FirstOrDefault(p => p.AuthorId == author.AuthorId);
                if (authorData != null)
                {
                    authorData.BirthDay = author.BirthDay;
                    authorData.Name = author.Name;
                    authorData.Image = author.Image;
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
