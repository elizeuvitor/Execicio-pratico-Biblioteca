﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppExercicio.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public int CategoriaId { get; set; }
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string NumeroExemplares { get; set; }
        public List<Autor> Autores { get; set; }
        public List<Requisicao> Requisicoes { get; set; }
        public Categoria Categoria { get; set; }
    }
}