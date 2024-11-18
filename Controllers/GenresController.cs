﻿using Bookstore.Models;
using Bookstore.Models.ViewModels;
using Bookstore.Services;
using Bookstore.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace Bookstore.Controllers
{

    public class GenresController : Controller
    {

        private readonly GenreService _service;

        public GenresController(GenreService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _service.FindAllAsync()); 
        }

        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Genre genre) 
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _service.InsertAsync(genre);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id) //Ponto de interrogação deixará a possibilidade do id ser nulo.
        {
            if (id is null)
            {
                return RedirectToAction(nameof(Error), new { message = "O ID não foi fornecido."}); //'nameof' faz o vínculo com a action, sendo alterada junto em caso de alteração no nome.
            }

            Genre genre = await _service.FindByIdAsync(id.Value);
            if (genre is null)
            {
                return RedirectToAction(nameof(Error), new { message = "O ID não foi encontrado." });
            }

            return View(genre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _service.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException ex)
            {
                return RedirectToAction(nameof(Error), new { message = ex.Message });
            }

        }

        public IActionResult Error(string message)
        {
            ErrorViewModel viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não fornecido"});
            }

            var obj = await _service.FindByIdAsync(id.Value);
            if (obj is null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não encontrado" });
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if(id!= genre.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "ID's não condizem" });
            }

            try
            {
                await _service.UpdateAsync(genre);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction(nameof(Error), new { message = ex.Message});
            }
        }   

        


    }
}

