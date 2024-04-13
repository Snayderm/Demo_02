﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
	public class Book : Product
	{
		public string Title { get; set; }
		public Book(int id, string name, decimal unitPrice, int unitsInStock, string title) :
			base(id, name, unitPrice, unitsInStock)
		{
			Title = title;
		}
	}
}