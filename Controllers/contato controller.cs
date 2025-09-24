using Microsoft.AspNetCore.Mvc;
using projeto_api.context;
using projeto_api.Controllers.Entitys;

namespace projeto_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class contato_controller : ControllerBase
    {


        private readonly Agenda _context;

        public contato_controller(Agenda context)
        { 
          
             _context = context;


        }

        [HttpPost]
        public IActionResult Create(Contatos contato)
        { 
        
          _context.Contatos.Add(contato);
            _context.SaveChanges();
            return Ok(contato);

        }

    }
}
