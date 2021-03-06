﻿using Library.Data.Model;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    public interface IBookAndBorrowerRepository
    {
		IQueryable<BookAndBorrowerViewModel> GetAll();
		IQueryable<BookAndBorrowerViewModel> Search(string searchFor, bool[] criteria);

	}
}
