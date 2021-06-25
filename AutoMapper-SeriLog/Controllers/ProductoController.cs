using AutoMapper_SeriLog.Entidades;
using AutoMapper_SeriLog.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace AutoMapper_SeriLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private IProductoServices ProductoServices;
        private readonly IMapper mapper;

        public ProductoController(IProductoServices _ProductoServices, IMapper _mapper)
        {
            ProductoServices = _ProductoServices;
            mapper = _mapper;
        }


        [HttpPost]
        public IActionResult Registro([FromBody] ProductoRequest producto) 
        {
            // Tradicional
            //Producto articulo = new Producto();
            //articulo.Descripcion = producto.Descripcion;
            //articulo.Precio = producto.Precio;
            //ProductoServices.Registro(articulo);

            // Con AutoMapper
            var articulo = mapper.Map<Producto>(producto);
            ProductoServices.Registro(articulo);

            return Ok();
        
        }



    }
}
