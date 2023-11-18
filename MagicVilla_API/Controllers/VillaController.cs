using MagicVilla_API.Data;
using MagicVilla_API.Models;
using MagicVilla_API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {

            return Ok(VillaStore.VillaList);
        }

        [HttpGet("onekind")]
        public ActionResult<VillaDTO> GetVilla(int id) 
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var result = VillaStore.VillaList.FirstOrDefault(v => v.ID == id);

            if(result == null)
            {
                return NotFound();
            }
            return result;
        }
    }
}
