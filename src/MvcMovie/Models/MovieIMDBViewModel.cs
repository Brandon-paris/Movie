using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieIMDBViewModel
    {

        public List<Movie> movies;
        public SelectList imdbs;
        public string movieIMDB { get; set; } 
    }
}
