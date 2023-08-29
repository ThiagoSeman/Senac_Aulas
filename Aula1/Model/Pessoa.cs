using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Model
{
    public class Pessoa
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public DateTime DataNac { get; set; }
        public string CPF { get; set; }
        public List<Endereco> endereco { get; set; }
        public Pessoa()
        {
        }
    }

    public class Endereco
    {
        public Guid id { get; set; }
        public Guid idCliente { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }

        public Endereco() { }
    }





}
