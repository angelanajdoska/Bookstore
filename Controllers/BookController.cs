using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bookstore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Bookstore.Data;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Bookstore.ViewModels;

namespace Bookstore.Controllers
{
  
    public class BookController : Controller
    {
        private readonly BookstoreContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BookController(BookstoreContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index(string searchString)
        {         
            ViewData["CurrentFilter"] = searchString;
           
            var books = from b in _context.Book
                   select b;
            if (!String.IsNullOrEmpty(searchString))
            {
                 books = books.Where(s => s.Title.Contains(searchString));
            }
          
         return View(await books.AsNoTracking().ToListAsync());
        }
        public async Task<IActionResult> Genre()
        {         
          return View(await _context.Book.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
{
    if (id == null)
    {
        return NotFound();
    }

    var book = await _context.Book
        .Include(s => s.Author)
        .AsNoTracking()
        .FirstOrDefaultAsync(m => m.BooksID == id);

    if (book == null)
    {
        return NotFound();
    }

    return View(book);
}
// GET: Book/Create
 public IActionResult Create()
        {
            return View();
        }
         [HttpPost]
        [ValidateAntiForgeryToken]
         public async Task<IActionResult> Create(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                Book book = new Book
                {
                    BooksID = model.BooksID,
                    Title = model.Title,
                    OriginalTitle = model.OriginalTitle,
                    Genre = model.Genre,
                    Synopsis = model.Synopsis,
                    NumberofPages = model.NumberofPages,
                    Picture = uniqueFileName,
                    Price=model.Price,
                    ReleaseDate=model.ReleaseDate,
                    Publisher = model.Publisher,
                    Movie= model.Movie,
                    Authors=model.Authors,
                    Author=model.Author,
                    Authorid=model.Authorid
                };

                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }             
            PopulateDropDownList();
            return View();
        }


        // GET: Book/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

             BookViewModel vm = new BookViewModel
                {
                    BooksID = book.BooksID,
                    Title = book.Title,
                    OriginalTitle = book.OriginalTitle,
                    Genre = book.Genre,
                    Synopsis = book.Synopsis,
                    NumberofPages = book.NumberofPages,
                    Price=book.Price,
                    ReleaseDate=book.ReleaseDate,
                    Publisher = book.Publisher,
                    Movie= book.Movie,
                    Authors=book.Authors,
                    Author=book.Author,
                    Authorid=book.Authorid
                };
            ViewData["Authorid"] = new SelectList(_context.Author, "Authorid", "FullName", book.Authorid);

            return View(vm);
        }

        // POST: Book/Edit/5
      
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
       public async Task<IActionResult> EditPost(int? id, BookViewModel vm)
        {
            if (id != vm.BooksID)
            {
                return NotFound();
            }

       if (ModelState.IsValid)
       {
           try
                {
                    string uniqueFileName = UploadedFile(vm);

               Book book = new Book
                {
                    BooksID = vm.BooksID,
                    Title = vm.Title,
                    OriginalTitle = vm.OriginalTitle,
                    Genre = vm.Genre,
                    Synopsis = vm.Synopsis,
                    NumberofPages = vm.NumberofPages,
                    Picture = uniqueFileName,
                    Price=vm.Price,
                    ReleaseDate=vm.ReleaseDate,
                    Publisher = vm.Publisher,
                    Movie= vm.Movie,
                    Authors=vm.Authors,
                    Author=vm.Author,
                    Authorid=vm.Authorid
                };

                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(vm.BooksID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
       }
             return View(vm);
          }

        

        private void PopulateDropDownList(object selectedauthor = null)
        {
            var authorQuery = from d in _context.Author
                                   orderby d.FullName
                                   select d;
            ViewBag.Author = new SelectList(authorQuery.AsNoTracking(), "Authorid", "FullName", selectedauthor);
        }
        
        
        // GET: Book/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(c => c.Author)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.BooksID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Book.FindAsync(id);
            _context.Book.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
          [HttpPost]
     
        private bool BookExists(int id)
        {
            return _context.Book.Any(e => e.BooksID == id);
        }
          private string UploadedFile(BookViewModel model)
        {
            string uniqueFileName = null;

            if (model.Picture != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "pictures");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(model.Picture.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Picture.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

    }
}