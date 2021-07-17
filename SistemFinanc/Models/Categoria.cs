using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemFinanc.Models
{
    public class Categoria
    {
        public List<Despesa> Catg { get; set; } = new List<Despesa>();

        public void addDespesa(Despesa despesas) 
        {
            Catg.Add(despesas);        
        }

    }
}
