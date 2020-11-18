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
	public class TtrainRadiosController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainRadio> lTtrainRadios = await db.TtrainRadio.GetAllCompanyTtrainRadios(id);
				 //return JsonConvert.SerializeObject(lTtrainRadios.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainRadio ttrainradio)
			{
				 //Create
				 db.TtrainRadio.Add(ttrainradio);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainradio);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainRadio ttrainradio)
			{
				 //Update
				 db.TtrainRadio.Update(ttrainradio);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainRadio ttrainradio)
			{
				 db.TtrainRadio.Remove(ttrainradio);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
