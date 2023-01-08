using Festival.Data;
using Festival.Models;
using Festival.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Festival.Controllers
{
    public class ArtiestController : Controller
    {
        private readonly ApplicationDbContext _context;
        public List<Artiest> artiesten;

        public ArtiestController(ApplicationDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(string ArtiestSearch)
        {
            ViewData["DagId"] = new SelectList(_context.Dagen, "DagId", "DagNaam");
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreId", "GenreNaam");

            ArtiestListViewModel viewModel = new ArtiestListViewModel();
           
            if(ArtiestSearch != "" )
            {
                viewModel.Artiesten = await _context.Artiesten.Include(a => a.Dag).Include(a => a.Genre).Where(emp => emp.Artiestnaam == ArtiestSearch || ArtiestSearch == null).ToListAsync();
            }       
            
                return View(viewModel);

            
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["DagId"] = new SelectList(_context.Dagen, "DagId", "DagNaam");
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreId", "GenreNaam");
            return View();
        }

        [HttpPost]

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("ArtiestId,Achternaam,Voornaam,Artiestnaam, Leeftijd, GenreId, DagId")] Artiest artiest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artiest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DagId"] = new SelectList(_context.Dagen, "DagId", "DagNaam", artiest.DagId);
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreId", "GenreNaam", artiest.GenreId);

            CreateArtiestViewModel vm = new CreateArtiestViewModel()
            {

                Achternaam = artiest.Achternaam,
                Voornaam = artiest.Voornaam,
                Artiestnaam = artiest.Artiestnaam,
                Leeftijd = artiest.Leeftijd,
                Genre = artiest.Genre,
                Dag = artiest.Dag

            };

            return View(vm);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artiest artiest = await _context.Artiesten.Include(a => a.Dag)
                .Include(a => a.Genre).Include(a => a.ArtiestSongs)
                .FirstOrDefaultAsync(m => m.ArtiestId == id);

            if (artiest == null)
            {
                return NotFound();
            }

            DetailsArtiestViewModel vm = new DetailsArtiestViewModel()
            {
                Achternaam = artiest.Achternaam,
                Voornaam = artiest.Voornaam,
                Artiestnaam = artiest.Artiestnaam,
                Leeftijd = artiest.Leeftijd,
                Genre = artiest.Genre,
                Dag = artiest.Dag,
                ArtiestSong = artiest.ArtiestSongs
                
                
            };

            return View(vm);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artiest artiest = await _context.Artiesten.FindAsync(id);

            if (artiest == null)
            {
                return NotFound();
            }
            ViewData["DagId"] = new SelectList(_context.Dagen, "DagId", "DagNaam", artiest.DagId);
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreId", "GenreNaam", artiest.GenreId);

            EditArtiestViewModel vm = new EditArtiestViewModel()
            {
                Achternaam = artiest.Achternaam,
                Voornaam = artiest.Voornaam,
                Artiestnaam = artiest.Artiestnaam,
                Leeftijd = artiest.Leeftijd,
                Genre = artiest.Genre,
                Dag = artiest.Dag
            };
            return View(vm);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id,
                [Bind("Achternaam,Voornaam,Artiestnaam, Leeftijd, GenreId, DagId")] Artiest artiest)
        {
            artiest.ArtiestId = id;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artiest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtiestExists(artiest.ArtiestId))
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
            EditArtiestViewModel vm = new EditArtiestViewModel()
            {
                Achternaam = artiest.Achternaam,
                Voornaam = artiest.Voornaam,
                Artiestnaam = artiest.Artiestnaam,
                Leeftijd = artiest.Leeftijd,
                Genre = artiest.Genre,
                Dag = artiest.Dag
            };

            return View(vm);
        }
        [AllowAnonymous]
        public IActionResult Search(ArtiestListViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(viewModel.ArtiestSearch))
            {
                viewModel.Artiesten = artiesten.Where(b =>
                    b.Voornaam.Contains(viewModel.ArtiestSearch)).ToList();
            }
            else
            {
                viewModel.Artiesten = artiesten;
            }
            return View("Index", viewModel);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var artiest = await _context.Artiesten.FirstOrDefaultAsync(m => m.ArtiestId == id);
            //var kl = await _context.Klanten.FindAsync(id);
            if (artiest == null)
            {
                return NotFound();
            }
            DeleteArtiestViewModel vm = new DeleteArtiestViewModel()
            {
                Achternaam = artiest.Achternaam,
                Voornaam = artiest.Voornaam,
                Artiestnaam = artiest.Artiestnaam,
                Leeftijd = artiest.Leeftijd,
                Genre = artiest.Genre,
                Dag = artiest.Dag
            };
            return View(vm);
        }

        //POST: (Localhost)/Klant/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artiest = await _context.Artiesten.FindAsync(id);
            _context.Artiesten.Remove(artiest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtiestExists(int id)
        {
            Artiest artiest = _context.Artiesten.Find(id);
            if (artiest != null)
            {
                return true;
            }
            return false;
        }
    }
}
