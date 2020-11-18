using Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
	[Route("api/[controller]")]
	//[Authorize]
	[ApiController]
	public class TpropulsionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tpropulsion> lTpropulsions = await db.Tpropulsion.GetAllCompanyTpropulsions(id);
				 //return JsonConvert.SerializeObject(lTpropulsions.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tpropulsion tpropulsion)
			{
				 //Create
				 db.Tpropulsion.Add(tpropulsion);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tpropulsion);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tpropulsion tpropulsion)
			{
				 //Update
				 db.Tpropulsion.Update(tpropulsion);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tpropulsion tpropulsion)
			{
				 db.Tpropulsion.Remove(tpropulsion);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
