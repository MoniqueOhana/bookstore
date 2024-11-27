﻿using Bookstore.Data;
using Bookstore.Models;
using Bookstore.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Services
{
    public class BookService
    {
        private readonly BookstoreContext _context;

        public BookService(BookstoreContext context)
        {
            _context = context;
        }
        public async Task<List<Book>> FindAllAsync()
        {
            return await _context.Books.Include(x => x.Books).ToListAsync();
        }
        public async Task InsertAsync(Book book)
        {
             _context.Add(book);
             await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Book book)
        {
            bool hasAny = await _context.Books.AnyAsync(x => x.Id == book.Id);
            if (hasAny)
            {
                throw new NotFoundException("Id não encontrado.");
            }

            try
            {
                _context.Update(book);
                await _context.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException ex)
            {
                throw new DbConcurrencyException(ex.Message);
            }
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Books.FindAsync(id);
                _context.Remove(obj);
                await _context.SaveChangesAsync();

            }
        }

    }
}