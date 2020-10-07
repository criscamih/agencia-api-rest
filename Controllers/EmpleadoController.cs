using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using  api_stock.Models;
using System.Text;
using api_stock.common.interfaces;
using Microsoft.AspNetCore.Http;

namespace api_stock.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadoController : ControllerBase{

        private readonly IDataAccessRepository<EmpleadoModel> _dataAccessEmpleado;
         public EmpleadoController(IDataAccessRepository<EmpleadoModel> dataAccessEmpleado)
         {
             _dataAccessEmpleado = dataAccessEmpleado;
         }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<EmpleadoModel>>> GetAllEmpleados()
        {
            var empleados = await _dataAccessEmpleado.GetAll() ?? null;

            if (empleados is null)
            {
                return NotFound();
            }

            return Ok(empleados);
        }
    }
}