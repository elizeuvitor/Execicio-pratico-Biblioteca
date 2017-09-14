using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppExercicio.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }
        public List<Livro> Livros { get; set; }
    }
}