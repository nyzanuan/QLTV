﻿using _1.DAL.Data;
using _1.DAL.IRepository;
using _1.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Digests;
using Sharing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly DataContext _dataContext;
        public ReportRepository()
        {
            _dataContext = new DataContext();
        }
        public List<MaxBookInfo> GetBook()
        {
            try
            {   
                var result = _dataContext.Book.Select(max => new MaxBookInfo
                {
                    BookName = max.Name,
                    Category = max.Category.Name,
                    Publisher = max.Publisher.Name,
                    Language = max.Language.Name,
                    BorrowedCopies = max.BorrowedCopies,
                }).OrderByDescending(max => max.BorrowedCopies).ToList();
                return result;
            }
            catch (Exception ex)
            {

                return new List<MaxBookInfo>();
            }
        }

        public List<QuantityInfo> GetQuantityBook()
        {
            try
            {
                var result = _dataContext.Book.Select(countbook => new QuantityInfo
                {
                    BookName = countbook.Name ,
                    Category = countbook.Category.Name,
                    Publisher = countbook.Publisher.Name,
                    Language = countbook.Language.Name,
                    AvailableCopies = countbook.AvailableCopies,
                }).ToList();
                return result;
            }
            catch (Exception ex)
            {

                return new List<QuantityInfo>();
            }
        }

        public List<ReceiptInfo> GetReceipt(DateTime startDate, DateTime endDate)
        {
            try
            {

                var result = _dataContext.LoanReceipt.Where(c => c.BorrowDate >= startDate && c.BorrowDate <= endDate).Select(a => new ReceiptInfo
                {
                   NameUser = a.Customer.Name,
                   EmailUser = a.Customer.Email,
                   BookName =  a.Book.Name,
                   StatusBook = a.Book.Status,
                   DayBorrow = a.BorrowDate,
                   DayReturn = a.ReturnDate,
                }).OrderBy(b => b.DayBorrow).ToList();
                return result;

            }catch (Exception ex) 
            {
                return new List<ReceiptInfo>();
            }
        }
    }
}
