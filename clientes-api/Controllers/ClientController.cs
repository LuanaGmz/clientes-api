using Microsoft.AspNetCore.Mvc;
using clientes_api.Models;
using clientes_api.Data;
using AutoMapper;
using clientes_api.Data.Dtos;

namespace clientes_api.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{

    private ClientContext _context;
    private IMapper _mapper;

    public ClientController(ClientContext context,
                            IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <summary>
    /// Método para inserir dados de um cliente
    /// </summary>
    /// <param name="clientDto">Objeto com os campos necessários para criação de um filme</param>
    /// <returns>IActionResult</returns>
    /// <response code="201">Caso inserção seja feita com sucesso</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult PostClient([FromBody] CreateClientDto clientDto)
    {
        Client client = _mapper.Map<Client>(clientDto);
        _context.Clients.Add(client);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetClientsPorCpf), new { Cpf = client.Cpf }, client);

    }

    /// <summary>
    /// Método para listar clientes
    /// </summary>
    /// <returns>Lista de clientes.</returns>
    /// <response code="200">Retorna lista de clientes</response>
    [HttpGet]
    public IEnumerable<Client> GetClient()
    {
        return _context.Clients;
    }

    /// <summary>
    /// Método para consultar dados de um cliente por cpf
    /// </summary>
    /// <param name="cpf">Id do cliente a ser consultado no banco</param>
    /// <returns>Dados de um cliente</returns>
    /// <response code="200">Retorna dados de um cliente</response>
    /// <response code="400">Erro ao consultar dados de um cliente</response>
    [HttpGet("{cpf}")]
    public IActionResult GetClientsPorCpf(string cpf)
    {
        Client client = _context.Clients.FirstOrDefault(client => client.Cpf == cpf);
        if (client != null)
        {
            ReadClientDto clientDto = _mapper.Map<ReadClientDto>(client);
            return Ok(clientDto);
        }
        return NotFound();
    }
}
