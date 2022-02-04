using Ecommerce.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Logica
{
    public class LogicaEcommerce : LogicaBase
    {
        public void Agregar(ARTICULOS articulo)
        {
            context.ARTICULOS.Add(articulo);
            context.SaveChanges();
        }

        public void Modificar(ARTICULOS articulo)
        {
            var articuloModificado = context.ARTICULOS.Find(articulo.ID);

            articuloModificado.NOMBRE = articulo.NOMBRE;
            articuloModificado.CODIGO = articulo.CODIGO;
            articuloModificado.DESCRIPCION = articulo.DESCRIPCION;
            articuloModificado.PRECIO = articulo.PRECIO;
            articuloModificado.IMG_URL = articulo.IMG_URL;
            articuloModificado.STOCK = articulo.STOCK;

            context.SaveChanges();
        }
        public void Eliminar(ARTICULOS articulo)
        {
            context.ARTICULOS.Remove(articulo);
            context.SaveChanges();
        }

        public List<ARTICULOS> Listar() => context.ARTICULOS.ToList();

        public ARTICULOS Buscar(int id) => context.ARTICULOS.Find(id);
    }
}

