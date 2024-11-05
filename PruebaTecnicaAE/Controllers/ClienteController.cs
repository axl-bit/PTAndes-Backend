using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaAE.Data;
using PruebaTecnicaAE.Models.DTO;
using PruebaTecnicaAE.Models.Entities;

namespace PruebaTecnicaAE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ClienteController(ApplicationDbContext dbContext) { this.dbContext = dbContext; }

        [HttpGet]
        public IActionResult GetAllClientes()
        {
            try
            {
                return Ok(dbContext.Clientes.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetClientesById(Guid id)
        {
            var clientebuscar = dbContext.Clientes.Find(id);

            if(clientebuscar is null) { return NotFound(); };

            return Ok(clientebuscar);
        }

        [HttpPost]
        public IActionResult AddCliente(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Nombres = clienteDto.Nombres,
                Apellidos = clienteDto.Apellidos,
                DocIdentificacion = clienteDto.DocIdentificacion,
                Celular = clienteDto.Celular
            };

            dbContext.Clientes.Add(cliente);
            dbContext.SaveChanges();
            return Ok(cliente);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateCliente(Guid id, ClienteDto clienteDto)
        {
            var clientebuscar = dbContext.Clientes.Find(id);

            if (clientebuscar is null) { return NotFound(); }

            clientebuscar.Nombres = clienteDto.Nombres;
            clientebuscar.Apellidos = clienteDto.Apellidos;
            clientebuscar.DocIdentificacion = clienteDto.DocIdentificacion;
            clientebuscar.Celular = clienteDto.Celular;

            dbContext.SaveChanges();

            return Ok(clientebuscar);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteCliente(Guid id)
        {
            var clientebuscar = dbContext.Clientes.Find(id);

            if (clientebuscar is null) { return NotFound(); }

            dbContext.Clientes.Remove(clientebuscar);

            return Ok(clientebuscar);
        }   
    }
}
