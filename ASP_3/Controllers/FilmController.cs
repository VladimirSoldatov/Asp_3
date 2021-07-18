using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_3.Pages;


namespace ASP_3
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        public List<Film> MyFilm { set; get; }
        public FilmController()
        {
            Index1Model i = new Index1Model();
            MyFilm = i.Films;
        }
        public string Name { set; get; }
        public void Add(Film film)
        {
            MyFilm.Add(film);
        }
        public void Sort()
        {
            MyFilm.Sort();
        }
        [HttpGet]
        public string[] GetFilms()
        {
            return new string[]
            {
               MyFilm[0].Name,MyFilm[0].Editor
            };
        }
        [HttpGet]
        public string GetFilmByName(string name)
        {
            Film result = null; ;
            foreach (var item in MyFilm)
            {
                if (item.Name == name)
                {
                    result =item;
                    break;
                }
            }
            if (result!=null)
            {
                return  $"Название фильма: {result.Name}\nРежисер: {result.Editor}\nОписание: {result.Description}\nЖанр: {result.Style}";
            }
            else
                return "Нет такого фильма";

        
        }
    }
}
