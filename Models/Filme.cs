﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmeAPI.Models
{
    public class Filme
    {
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }
        public int Id { get; set; }
    }
}
