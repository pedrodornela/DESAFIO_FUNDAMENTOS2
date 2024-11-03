using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DESAFIO_FUNDAMENTOS2.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public Pessoa(string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;
        }
        public string Nome { get; set; }
        public string SobreNome { get; set;}
        public string NomeCompleto => $"{Nome} {SobreNome}".ToString();


    }
}