using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpotifyAPIIntegrationApplication.Services;

namespace SpotifyAPIIntegrationApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalController : ControllerBase
    {
        private readonly IJournalServices journalServices;

        public JournalController(IJournalServices journal)
        {
            journalServices = journal;
        }

        [HttpGet("/journals")]
        public async Task<IActionResult> GetJournal() {
        var result = await journalServices.GetJournals();
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
