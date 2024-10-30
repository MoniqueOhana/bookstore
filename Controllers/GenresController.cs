using Microsoft.AspNetCore.Mvc;
using Bookstore.Models;
namespace Bookstore.Controllers {

	public class GenresController : Controller
	{
		public IActionResult Index()
		{
			List<Genre> genres = new List<Genre>
			{
				new Genre
				{
					Id = 1,
					Name = "Nacional"
				},
				new Genre
				{
					Id = 2,
					Name = "Suspense"

				},
                new Genre
                {
                    Id = 3,
                    Name = "Animação"

                }


            };

			return View(genres);
		}
	}
}
