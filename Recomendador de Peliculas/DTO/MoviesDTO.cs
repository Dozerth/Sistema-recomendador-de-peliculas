﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recomendador_de_Peliculas.DTO
{
    public class MoviesDTO
    {
        int _ID;
        string _Title;
        string _Year;
        string _Link;
        string _Image;
        string _Description;
        string _Actors;

        public int ID { get => _ID; set => _ID = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string Year { get => _Year; set => _Year = value; }
        public string Link { get => _Link; set => _Link = value; }
        public string Image { get => _Image; set => _Image = value; }
        public string Description { get => _Description; set => _Description = value; }
        public string Actors { get => _Actors; set => _Actors = value; }
    }
}
