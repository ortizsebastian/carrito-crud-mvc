using Ecommerce.Entidades;
using Ecommerce.Logica;
using Ecommerce.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.UI.Controllers
{
    public class CarritoController : Controller
    {
        LogicaEcommerce logica = new LogicaEcommerce();

        List<ArticuloView> articuloViews = new List<ArticuloView>();

        // GET: Carrito
        public ActionResult Index()
        {
            if (Request.QueryString["ID"] != null)
            {
                if (Session["Carrito"] != null)
                    articuloViews = (List<ArticuloView>)Session["Carrito"];

                ARTICULOS articulo = logica.Buscar(int.Parse(Request.QueryString["ID"]));

                articuloViews.Add(new ArticuloView
                {
                    ID = articulo.ID,
                    Nombre = articulo.NOMBRE,
                    Codigo = articulo.CODIGO,
                    Descripcion = articulo.DESCRIPCION,
                    Precio = articulo.PRECIO,
                    UrlImagen = articulo.IMG_URL,
                    Stock = articulo.STOCK
                });

                Session["Carrito"] = articuloViews;
            }
            articuloViews = (List<ArticuloView>)Session["Carrito"];
            return View(articuloViews);
        }

        public ActionResult Eliminar(int id)
        {
            articuloViews = (List<ArticuloView>)Session["Carrito"];

            articuloViews.Remove(articuloViews.Find(a => a.ID == id));

            Session["Carrito"] = articuloViews;

            return View("Index", articuloViews);
        }
    }
}
