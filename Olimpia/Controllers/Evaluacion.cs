using BussinesLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Olimpia.Helpers.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Olimpia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Evaluacion : ControllerBase
    {
        private readonly ILogger<Evaluacion> _logger;
        private readonly IMultiploTresServices _multiploTresServices = null;

        public Evaluacion(ILogger<Evaluacion> logger)
        {
            _logger = logger;
            this._multiploTresServices = new MultiploTresServices();
        }

        /// <summary>
        /// Se debe crear el archivo en la ruta c:\temp\MyTest.txt
        /// </summary>
        /// <returns>Os itens da To-do list</returns>
        /// <response code="200">Retorna la lista indicando cual de los numeros del archivo es multiplo de 3</response>
        [Route("[action]")]
        [HttpGet]
        public IActionResult PuntoUno()
        {
            try
            {
                var data = _multiploTresServices.GetMultiploTres();
                return new OkObjectResult(new ApiResponse
                {
                    status = HttpStatusCode.OK,
                    data = data
                });
            }
            catch (Exception ex)
            {
                return new OkObjectResult(new ApiResponse
                {
                    status = HttpStatusCode.BadRequest,
                    Message = ex.InnerException.ToString()
                });
            }
            
        }
    }
}
