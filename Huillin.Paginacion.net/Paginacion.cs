using System.Collections.Generic;

namespace Huillin.Paginacion.net
{
  public class Paginacion<T>
    {
        public int NumeroPagina { get; set; }
        public int TamanioPagina { get; set; }
        public int Total { get; set; }
        public IList<T> Items { get; set; }
    }
}
