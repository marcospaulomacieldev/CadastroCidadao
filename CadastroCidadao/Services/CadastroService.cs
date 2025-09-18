using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroCidadao.Models;
using CadastroCidadao.Utils;

namespace CadastroCidadao.Services
{
    public class CadastroService
    {
        private List<Cidadao> _cidadaos = new List<Cidadao>();

        public string Cadastrar(string nome, string cpf)
        {
            if (!ValidadorCPF.Validar(cpf))
                return "CPF inválido!";

            if (_cidadaos.Any(c => c.CPF == cpf))
                return "Cidadão já cadastrado!";

            _cidadaos.Add(new Cidadao(nome, cpf));
            return "Cadastrado com sucesso!";
        }

        public Cidadao BuscarPorCPF(string cpf)
        {
            return _cidadaos.FirstOrDefault(c => c.CPF == cpf);
        }

        public Cidadao BuscarPorNome(string nome)
        {
            return _cidadaos.FirstOrDefault(c => c.Nome.ToLower() == nome.ToLower());
        }
    }
}

