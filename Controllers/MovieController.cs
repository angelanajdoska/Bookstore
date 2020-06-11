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
  
    public class MovieController : Controller
    {
       private readonly BookstoreContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MovieController(BookstoreContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {         
          return View(await _context.Movie.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
{
    if (id == null)
    {
        return NotFound();
    }

    var movie = await _context.Movie
        .Include(s => s.Book)
        .AsNoTracking()
        .FirstOrDefaultAsync(m => m.MovieID == id);

    if (movie == null)
    {
        return NotFound();
    }

    return View(movie);
}
        public IActionResult Create()
        {
            PopulateDropDownList();
            return View();
        }
         [HttpPost]
        [ValidateAntiForgeryToken]
       public async Task<IActionResult> Create(MovieViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                Movie movie = new Movie
                {
                    MovieID = model.MovieID,
                    Title = model.Title,
                    Synopsis = model.Synopsis,
                    BookId=model.BookId,
                    Picture = uniqueFileName,
                    ReleaseDate=model.ReleaseDate,
                    Trailer = model.Trailer,
                    Rating= model.Rating,
                    Book=model.Book
                };

                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopulateDropDownList();
            return View();
        }


        // GET: Movie/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

              MovieViewModel vm = new MovieViewModel
                {
                    MovieID = movie.MovieID,
                    Title = movie.Title,
                    Synopsis = movie.Synopsis,
                    BookId=movie.BookId,
                    ReleaseDate=movie.ReleaseDate,
                    Trailer = movie.Trailer,
                    Rating= movie.Rating,
                    Book=movie.Book
                };

            ViewData["BookId"] = new SelectList(_context.Book, "BookId", "Title", movie.BookId);
            return View(vm);
        }

        // POST: Movie/Edit/5
      
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id, MovieViewModel vm)
        {
            if (id != vm.MovieID)
            {
                return NotFound();
            }

       if (ModelState.IsValid)
       {
           try
                {
                    string uniqueFileName = UploadedFile(vm);

                Movie movie = new Movie
                {
                    MovieID = vm.MovieID,
                    Title = vm.Title,
                    Synopsis = vm.Synopsis,
                    BookId=vm.BookId,
                    Picture = uniqueFileName,
                    ReleaseDate=vm.ReleaseDate,
                    Trailer = vm.Trailer,
                    Rating= vm.Rating,
                    Book=vm.Book
                };

                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(vm.MovieID))
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

        private void PopulateDropDownList(object selectedbook = null)
        {
            var bookQuery = from d in _context.Book
                                   orderby d.Title
                                   select d;
            ViewBag.Book = new SelectList(bookQuery.AsNoTracking(), "BookId", "Title", selectedbook);
        }
        
        
        // GET: Movie/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .Include(c => c.Book)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.MovieID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
          [HttpPost]
     
        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.MovieID == id);
        }
         private string UploadedFile(MovieViewModel model)
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