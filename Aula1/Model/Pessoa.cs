using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Model
{
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime DataNac { get; set; }
        public string CPF { get; set; }
        public Endereco endereco { get; set; }
    }

    public class Endereco
    {
        public int id { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
    }



}
