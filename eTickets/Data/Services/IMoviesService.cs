﻿using eTickets.Data.Base;
using eTickets.Data.ViewModel;
using eTickets.Models;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IMoviesService: IEntityBaseRepository<Movie>
    {
       Task<Movie> GetMovieByIdAsync(int id);
       Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        // Task<NewMovieDropDownVM> GetNewMovieDropDownValues();
    }
}
