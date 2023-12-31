﻿using FastKart.Data.Entities;
using FastKart.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastKart.Data.Repositories
{
    [NotMapped]
    public class BrandRepository : IBrandRepository
    {
        private readonly AppDbContext _context;
        public BrandRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Brand item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public void AddRange(IEnumerable<Brand> items)
        {
            _context.AddRange(items);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Brands.Count();
        }

        public void Delete(Brand item)
        {
            _context.Remove(item);
        }
        public void Delete(int BrandId)
        {
            var Brand = _context.Brands.Find(BrandId);
            Delete(Brand);
        }

        public IEnumerable<Brand> Filter(Predicate<Brand> Condition)
        {
            return _context.Brands.Where(B => Condition(B));
        }

        public IEnumerable<Brand> FilterPage(Predicate<Brand> Condition, int page, int pageSize)
        {
            return Filter(Condition).Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<Brand> GetAll()
        {
            return _context.Brands;
        }

        public IEnumerable<Brand> GetPage(int page, int pageSize)
        {
            return _context.Brands.Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<Product> GetProductsPaginate(int Page, int PageSize, Brand Brand)
        {
            return Brand.Products.Skip(Page * PageSize).Take(PageSize);
        }

        public IEnumerable<Product> GetProductsPaginate(int Page, int PageSize, int BrandId)
        {
            var Brand = _context.Brands.Find(BrandId);
            return Brand.Products.Skip(Page * PageSize).Take(PageSize);
        }

        public IEnumerable<TResult> Select<TResult>(Func<Brand, TResult> func)
        {
            return _context.Brands.Select(B => func(B));
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<Brand, TResult> func, int page, int pageSize)
        {
            return Select(func).Skip(page * pageSize).Take(pageSize);
        }

        public void Update(Brand item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
