﻿using Business_logic_layer.interfaces;
using Data_access_layer.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic_layer.Repository
{
    public class genericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public genericRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T item)
        {

            await _context.AddAsync(item);
        }

        public void DeleteAsync(T item)
        {
            _context.Remove(item);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            if (typeof(T) == typeof(Revision))
                return (IEnumerable<T>)_context.Revisions.Include(d => d.Course).ToList();
            else
            {
                return await _context.Set<T>().ToListAsync();
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void UpdateAsync(T item)
        {
            _context.Update(item);
        }
    }
}
