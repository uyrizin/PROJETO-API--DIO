namespace projeto_api.Controllers.Entitys;

public class Contatos
{
    public int Id { get; set; }
    public string nome { get; set; } = string.Empty;
    public string telefone { get; set; } = string.Empty;
    public bool Ativo { get; set; }
}
