using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
        public int idProducto {get;set;}
        public string descripcionProducto{get;set;}
        public int cantidadProducto{get;set;}
        public double precioProducto{get;set;}
        public string subFamiliaProducto{get;set;}
        public string marcaProducto{get;set;}
        public string presentacionProducto { get; set; }

        public Producto(int p_id, string p_descripcion, int p_cantidad, double p_precio, string p_subFamilia, string p_marca, string p_presentacion)
        {
            this.idProducto = p_id;
            this.descripcionProducto = p_descripcion;
            this.cantidadProducto = p_cantidad;
            this.precioProducto = p_precio;
            this.subFamiliaProducto = p_subFamilia;
            this.marcaProducto = p_marca;
            this.presentacionProducto = p_presentacion;
        }
    }
}
