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
    public class NXBRepository : INXBRepository
    {
        private readonly DataContext _dataContext;
        public NXBRepository()
        {
            _dataContext = new DataContext();
        }
        public bool SaveData()
        {
            var result = _dataContext.SaveChanges() > 0;
            return result;
        }
        public bool AddPub(Publisher publisher)
        {
            try
            {
                _dataContext.Publisher.Add(publisher);
                return SaveData();
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePub(int id)
        {
            try
            {
                var p = _dataContext.Publisher.FirstOrDefault(p => p.PublisherId == id);
                _dataContext.Publisher.Remove(p);
                return SaveData();
            }
            catch
            {
                return false;
            }
        }

        public ValueReturn GetAllPub(int pageIndex, int pageSize, string? search)
        {
            try
            {
                var query = _dataContext.Publisher.AsQueryable();
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
                        ListElemnent = Array.Empty<Publisher>(),
                        TotalElemnent = 0

                    }
                };
            }
        }

        public bool UpdatePub(Publisher publisher)
        {
            try
            {
                var publisherData = _dataContext.Publisher.FirstOrDefault(p => p.PublisherId == publisher.PublisherId);
                if (publisherData != null)
                {
                    publisherData.Name = publisher.Name;
                    publisherData.Image = publisher.Image;
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
