using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLivros.Data;
using ApiLivros.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiLivros.Controllers;

[ApiController]
[Route("[controller]")]
public class LivroController : ControllerBase
{
    private LivroContext lc;

    public LivroController(LivroContext lc)
    {
        this.lc = lc;
    }

    [HttpGet]
    public async Task<ActionResult> ListarLivros()
    {
        var dados = await lc.Livros.ToListAsync();
        return Ok(dados);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> ListarLivrosPorId(int id)
    {
        var livroId = await lc.Livros.FirstAsync(lv => lv.Id == id);
        return Ok(livroId);
    }

    [HttpPost]
    public async Task<ActionResult> AdicionarLivros([FromBody] Livro livro)
    {
        lc.Livros.Add(livro);
        await lc.SaveChangesAsync();
        return Created("Objeto livro", livro);
    }

    [HttpPut]
    public async Task<ActionResult> EditarLivros([FromBody] Livro livro)
    {
        lc.Livros.Update(livro);
        await lc.SaveChangesAsync();
        return Ok(livro);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeletarLivros(int id)
    {
        var livroId = await lc.Livros.FirstOrDefaultAsync(c => c.Id == id);

        if (livroId == null)
        {
            return NotFound();
        }
        else 
        {
            lc.Livros.Remove(livroId);
            await lc.SaveChangesAsync();
            return Ok();
        }
    }        
}