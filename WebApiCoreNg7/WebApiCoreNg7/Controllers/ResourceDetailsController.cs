using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCoreNg7.Models;

namespace WebApiCoreNg7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceDetailsController : ControllerBase
    {
        private readonly ResourceDetailsContext _context;

        public ResourceDetailsController(ResourceDetailsContext context)
        {
            _context = context;
        }

        // GET: api/ResourceDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResourceDetails>>> GetResourceDetails()
        {
            return await _context.ResourceDetails.ToListAsync();
        }

        // GET: api/ResourceDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ResourceDetails>> GetResourceDetails(int id)
        {
            var resourceDetails = await _context.ResourceDetails.FindAsync(id);

            if (resourceDetails == null)
            {
                return NotFound();
            }

            return resourceDetails;
        }

        // PUT: api/ResourceDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResourceDetails(int id, ResourceDetails resourceDetails)
        {
            if (id != resourceDetails.ResID)
            {
                return BadRequest();
            }

            _context.Entry(resourceDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResourceDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ResourceDetails
        [HttpPost]
        public async Task<ActionResult<ResourceDetails>> PostResourceDetails(ResourceDetails resourceDetails)
        {
            _context.ResourceDetails.Add(resourceDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResourceDetails", new { id = resourceDetails.ResID }, resourceDetails);
        }

        // DELETE: api/ResourceDetails/5  
        [HttpDelete("{id}")]
        public async Task<ActionResult<ResourceDetails>> DeleteResourceDetails(int id)
        {
            var resourceDetails = await _context.ResourceDetails.FindAsync(id);
            if (resourceDetails == null)
            {
                return NotFound();
            }

            _context.ResourceDetails.Remove(resourceDetails);
            await _context.SaveChangesAsync();

            return resourceDetails;
        }

        private bool ResourceDetailsExists(int id)
        {
            return _context.ResourceDetails.Any(e => e.ResID == id);
        }
    }
}
