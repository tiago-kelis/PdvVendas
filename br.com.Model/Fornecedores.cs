using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdvVendas.br.com.Model
{
    public class Fornecedores
    {
       private int _Id;
       private string _nome;
       private string _Endereco;
       private string _Telefone;
       private  string _Cpf;
       private  string _Cargo;
       private string _TxtBuscar;
      
      
        public int Id { get => _Id; set => _Id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Endereco { get => _Endereco; set => _Endereco = value; }
        public string Telefone { get => _Telefone; set => _Telefone = value; }
        public string Cpf { get => _Cpf; set => _Cpf = value; }
        public string Cargo { get => _Cargo; set => _Cargo = value; }
        public string TxtBuscar { get => _TxtBuscar; set => _TxtBuscar = value; }

        public Fornecedores()
        {

        }

        public Fornecedores(int id, string nome, string endereco, string telefone, string cpf, string cargo, string txtBuscar, string txtbuscar)
        {
            this.Id = id;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Cargo = cargo;            
            this.TxtBuscar = txtBuscar;
        }

    }
}
