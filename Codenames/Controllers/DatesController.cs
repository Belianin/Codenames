using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Codenames.Controllers
{
    [Route("api/v1/dates")]
    public class DatesController : Controller
    {
        private readonly INamesRepository repository = new RandomNamesRepository();

        [HttpGet()]
        public IActionResult GetDate()
        {
            var names = repository.GetByDate(DateTime.Now);
            return Ok(string.Join("\n", names.Select(n => $"{n.Value}\t{string.Join(", ", n.Traits.Select(t => $"{t.Name}: {t.Mark}"))}")));
        }
    }
}