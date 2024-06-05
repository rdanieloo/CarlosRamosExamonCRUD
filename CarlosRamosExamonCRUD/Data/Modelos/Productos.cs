using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosRamosExamonCRUD.Data.Modelos
{
    //tome de guia la clase virtual que tuvimos
    internal class Productos
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string SKU { get; set; }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public decimal CostoProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Disponible { get; set; }
        public byte[] Imagen { get; set; } // Propiedad para almacenar la imagen como un array de bytes


    
    }



}
