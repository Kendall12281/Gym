using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGym.Layeres.Entities
{
   public class Entrenamiento
    {
        public string Id { get; set; }
        public char CodigoSexo { get; set; }
        public int EdadMinima { get; set; }
        public int EdadMaxima { get; set; }
        public string Descripcion { get; set; }
        
    }
}
