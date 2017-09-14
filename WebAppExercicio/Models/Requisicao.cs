using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppExercicio.Models
{
    public class Requisicao
    {
        public int RequisicaoId { get; set; }
        public int LivroId { get; set; }
        public DateTime DataRequisicao { get; set; }
        public DateTime DataEntrega { get; set; }
        public List<Funcionario> Funciomarios { get; set; }
        public Livro Livro { get; set; }
        public int Alunoid { get; set; }
        public Aluno Aluno { get; set; }
    }
}