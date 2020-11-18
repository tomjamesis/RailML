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
	public class TpantographsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tpantograph> lTpantographs = await db.Tpantograph.GetAllCompanyTpantographs(id);
				 //return JsonConvert.SerializeObject(lTpantographs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tpantograph tpantograph)
			{
				 //Create
				 db.Tpantograph.Add(tpantograph);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tpantograph);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tpantograph tpantograph)
			{
				 //Update
				 db.Tpantograph.Update(tpantograph);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tpantograph tpantograph)
			{
				 db.Tpantograph.Remove(tpantograph);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
