﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_asp.net_core_curso_Udemy.Models
{
    public class Palavra
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public int Pontuacao { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criado  { get; set; }
        //? significa que pode ser nulo
        public DateTime? Atualizado  { get; set; }
    }
}
