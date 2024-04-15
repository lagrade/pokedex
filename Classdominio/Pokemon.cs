using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classdominio

{
    public class Pokemon
    {
        public int Id { get; set; }
        //DispleyName sirve para declarar el formato o nombre que lleva en la grilla
        //pertenece al using ComponentModel
        [DisplayName("Número")]
        public int Numero { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public string UrlImagen { get; set;}

        public Elemento tipo { get; set; }
        public Elemento Debilidad { get; set; }
    }
}
