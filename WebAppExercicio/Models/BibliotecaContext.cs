using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppExercicio.Models
{
    public class BibliotecaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BibliotecaContext() : base("name=BibliotecaContext")
        {
        }

        public System.Data.Entity.DbSet<WebAppExercicio.Models.Aluno> Alunoes { get; set; }

        public System.Data.Entity.DbSet<WebAppExercicio.Models.Autor> Autors { get; set; }

        public System.Data.Entity.DbSet<WebAppExercicio.Models.Categoria> Categorias { get; set; }

        public System.Data.Entity.DbSet<WebAppExercicio.Models.Endereco> Enderecoes { get; set; }

        public System.Data.Entity.DbSet<WebAppExercicio.Models.Funcionario> Funcionarios { get; set; }

        public System.Data.Entity.DbSet<WebAppExercicio.Models.Livro> Livroes { get; set; }

        public System.Data.Entity.DbSet<WebAppExercicio.Models.Requisicao> Requisicaos { get; set; }
    }
}
