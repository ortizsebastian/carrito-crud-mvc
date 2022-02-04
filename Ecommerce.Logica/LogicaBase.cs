using Ecommerce.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Logica
{
    public class LogicaBase
    {
        protected readonly EcommerceContext context;

        public LogicaBase()
        {
            context = new EcommerceContext();
        }
    }
}
