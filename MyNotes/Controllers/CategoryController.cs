using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyNotes.Models;
using MyNotes.Repositoroy;

namespace MyNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepository<Category> _repository;

        public CategoryController(IRepository<Category> repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await _repository.GetAllAsync();
            return Ok(list);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByid(int id)
        {
            var list = await _repository.GetByIdAsync(id);
            return Ok(list);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Category category)
        {
            await _repository.AddAsync(category);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok(Delete(id));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Category category)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity != null)
            {
                await _repository.UpdateAsync(entity);

            }


            return Ok();
        }
    }
}
