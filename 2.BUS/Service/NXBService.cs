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
    public class NXBService : INXBService
    {
        private readonly INXBRepository _nXBRepository;
        public NXBService()
        {
            _nXBRepository = new NXBRepository();
        }

        public bool AddPub(Publisher publisher)
        {
            return _nXBRepository.AddPub(publisher);
        }

        public bool DeletePub(int id)
        {
            return (_nXBRepository.DeletePub(id));
        }

        public ValueReturn GetAllPub(int pageIndex, int pageSize, string? search)
        {
            try
            {
                ValueReturn result = _nXBRepository.GetAllPub(pageIndex, pageSize, search);
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
                        ListElemnent = Array.Empty<Publisher>(),
                    }

                };
            }
        }

        public bool UpdatePub(Publisher publisher)
        {
            return _nXBRepository.UpdatePub(publisher);
        }
    }
}
