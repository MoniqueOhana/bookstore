﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
namespace Bookstore.Models
{
	public class Genre
	{
			public int Id { get; set; }

			[Display(Name = "Nome")]
			public string Name { get; set; }

			//public ICollection<Book> Books { get; set; } = new List<Book>();

			public Genre()
			{

			}
			public Genre(int id, string name)
			{
				Id = id;
				Name = name;
			}

	}

}