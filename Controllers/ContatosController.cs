using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto_api.context;
using projeto_api.Controllers.Entitys;

namespace projeto_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContatosController : ControllerBase
{
    private readonly Agenda _context;

    public ContatosController(Agenda context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Contatos>>> GetAll(CancellationToken cancellationToken)
    {
        var contatos = await _context.Contatos
            .AsNoTracking()
            .ToListAsync(cancellationToken);

        return Ok(contatos);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Contatos>> GetById(int id, CancellationToken cancellationToken)
    {
        var contato = await _context.Contatos
            .AsNoTracking()
            .FirstOrDefaultAsync(item => item.Id == id, cancellationToken);

        return contato is null ? NotFound() : Ok(contato);
    }

    [HttpPost]
    public async Task<ActionResult<Contatos>> Create(
        [FromBody] Contatos contato,
        CancellationToken cancellationToken)
    {
        _context.Contatos.Add(contato);
        await _context.SaveChangesAsync(cancellationToken);

        return CreatedAtAction(nameof(GetById), new { id = contato.Id }, contato);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(
        int id,
        [FromBody] Contatos contato,
        CancellationToken cancellationToken)
    {
        var contatoExistente = await _context.Contatos
            .FirstOrDefaultAsync(item => item.Id == id, cancellationToken);

        if (contatoExistente is null)
        {
            return NotFound();
        }

        contatoExistente.nome = contato.nome;
        contatoExistente.telefone = contato.telefone;
        contatoExistente.Ativo = contato.Ativo;

        await _context.SaveChangesAsync(cancellationToken);

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        var contato = await _context.Contatos
            .FirstOrDefaultAsync(item => item.Id == id, cancellationToken);

        if (contato is null)
        {
            return NotFound();
        }

        _context.Contatos.Remove(contato);
        await _context.SaveChangesAsync(cancellationToken);

        return NoContent();
    }
}
