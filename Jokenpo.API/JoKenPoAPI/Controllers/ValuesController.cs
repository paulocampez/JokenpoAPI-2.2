using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Jokenpo.Model;
using JoKenPoAPI.Data;
using JoKenPoAPI.Data.Strategies;
using JoKenPoAPI.Data.Strategies.Database;
using Microsoft.AspNetCore.Mvc;

namespace JoKenPoAPI.Controllers
{
    [Route("api/Values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public JokenpoContext _context;

        public ValuesController(JokenpoContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retorna Todos os Funcionarios
        /// </summary>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public ActionResult<List<Jogo>> Get()
        {
            var context = new Context(new  FileStrategy());
            List<Jogo> lstJogo = new List<Jogo>();

            lstJogo = context.Get();

            if (lstJogo.Count == 0)
                return NotFound();

            return lstJogo;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            //var context = new Context(new FileStrategy());
            
            return "value";
        }

        // POST api/values
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public bool Post([FromBody] Jogo value)
        {
            var context = new Context(new FileStrategy());
            var success = context.Post(value);

            return true;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
