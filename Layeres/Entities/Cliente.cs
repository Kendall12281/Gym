using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGym.Layeres.Entities
{
    public class Cliente
    {
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public char CodigoSexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public short Peso { get; set; }
        public short Estatura { get; set; }
        public short Cintura { get; set; }
        public byte[] Foto { get; set; }

        public int Edad
        {
            get
            {
                return DateTime.Now.Year - FechaNacimiento.Year;
            }
        }
    }
}
