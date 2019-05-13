using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ProdutosContext _context;

        public ProdutosController(/*ProdutosContext context*/)
        {
            //_context = context;
            _context = new ProdutosContext();
        }

        // GET: api/Produtos
        [HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        //// GET: api/Produtos/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Produto>> GetProduto(string id)
        //{
        //    var produto = await _context.Produtos.FindAsync(id);

        //    if (produto == null)
        //    {
        //        return NotFound();
        //    }

        //    return produto;
        //}

        //// PUT: api/Produtos/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProduto(string id, Produto produto)
        //{
        //    if (id != produto.Nome)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(produto).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProdutoExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Produtos
        //[HttpPost]
        //public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        //{
        //    _context.Produtos.Add(produto);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetProduto", new { id = produto.Nome }, produto);
        //}

        //// DELETE: api/Produtos/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Produto>> DeleteProduto(string id)
        //{
        //    var produto = await _context.Produtos.FindAsync(id);
        //    if (produto == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Produtos.Remove(produto);
        //    await _context.SaveChangesAsync();

        //    return produto;
        //}

        private bool ProdutoExists(string id)
        {
            return _context.Produtos.Any(e => e.Nome == id);
        }
    }
}
