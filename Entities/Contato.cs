using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraApiAspNet.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public int Telefone { get; set; }
        public bool Ativo { get; set; }

    }
}