using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemFinanc.Models
{
    public class Despesa
    {
        public string nome { get; set; }
        public object Categoria { get; set; }
        public double Valor { get; set; }
        public DateTime data { get; set; }

    }

}
