namespace clientes_api.Data.Dtos;

public class ReadClientDto
{
    public int Id { get; set; }
    public string Cpf { get; set; }
    public string NomeCompleto { get; set; }
    public string Email { get; set; }
    public string Logradouro { get; set; }
    public string Complemento { get; set; }
    public string NumeroLogradouro { get; set; }
    public string Cidade { get; set; }
    public string SiglaUf { get; set; }
    public string Cep { get; set; }
    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;

}
