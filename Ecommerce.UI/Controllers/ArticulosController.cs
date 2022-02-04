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
    public class ArticulosController : Controller
    {
        LogicaEcommerce logica = new LogicaEcommerce();

        public ActionResult Index()
        {
            List<ARTICULOS> articulos = logica.Listar();

            List<ArticuloView> articulosVista = articulos.Select(a => new ArticuloView
            {
                ID = a.ID,
                Nombre = a.NOMBRE,
                Codigo = a.CODIGO,
                Descripcion = a.DESCRIPCION,
                Precio = a.PRECIO,
                UrlImagen = a.IMG_URL,
                Stock = a.STOCK
            }).ToList();

            return View(articulosVista);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(ArticuloView articuloView)
        {
            try
            {
                var articulo = new ARTICULOS
                {
                    ID = articuloView.ID,
                    CODIGO = articuloView.Codigo,
                    DESCRIPCION = articuloView.Descripcion,
                    NOMBRE = articuloView.Nombre,
                    PRECIO = articuloView.Precio,
                    IMG_URL = articuloView.UrlImagen,
                    STOCK = articuloView.Stock
                };

                logica.Agregar(articulo);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }


        public ActionResult Modificar()
        {
            List<ARTICULOS> articulos = logica.Listar();

            if(Request.QueryString["ID"] == null)          
                return RedirectToAction("Index");
            

            var Articulo = articulos.Find(a => a.ID == int.Parse(Request.QueryString["ID"]));

            var articuloView = new ArticuloView
            {
                ID = Articulo.ID,
                Codigo = Articulo.CODIGO,
                Nombre = Articulo.NOMBRE,
                Precio = Articulo.PRECIO,
                Descripcion = Articulo.DESCRIPCION,
                UrlImagen = Articulo.IMG_URL,
                Stock = Articulo.STOCK
            };

            return View(articuloView);
        }


        [HttpPost]
        public ActionResult Modificar(ArticuloView articuloView)
        {
            try
            {
                var articulo = new ARTICULOS
                {
                    ID = articuloView.ID,
                    CODIGO = articuloView.Codigo,
                    DESCRIPCION = articuloView.Descripcion,
                    NOMBRE = articuloView.Nombre,
                    PRECIO = articuloView.Precio,
                    IMG_URL = articuloView.UrlImagen,
                    STOCK = articuloView.Stock
                };

                logica.Modificar(articulo);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult Eliminar()
        {
            List<ARTICULOS> articulos = logica.Listar();

            logica.Eliminar(articulos.Find(a => a.ID == int.Parse(Request.QueryString["ID"])));

            return RedirectToAction("Index");
        }
    }
}