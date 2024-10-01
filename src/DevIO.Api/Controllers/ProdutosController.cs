using DevIO.Api.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.Controllers
{
    [Route("api/produtos")]
    public class ProdutosController : MainController
    {
        public ProdutosController()
        {
        }

        [HttpGet]
        public async Task<IEnumerable<ProdutoDTO>> ObterTodos()
        {
            return null;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ProdutoDTO>> ObterPorId(Guid id)
        {
            return null;
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoDTO>> Adicionar(ProdutoDTO produtoViewModel)
        {
            return null;
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Atualizar(Guid id, ProdutoDTO produtoViewModel)
        {
            return null;
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ProdutoDTO>> Excluir(Guid id)
        {
            return null;
        }
    }
}
