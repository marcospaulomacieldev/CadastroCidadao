using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCidadao.Models
{
    public class Cidadao
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Cidadao(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
    }
}

