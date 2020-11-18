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
	public class EtrainRadiosController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrainRadio> lEtrainRadios = await db.EtrainRadio.GetAllCompanyEtrainRadios(id);
				 //return JsonConvert.SerializeObject(lEtrainRadios.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrainRadio etrainradio)
			{
				 //Create
				 db.EtrainRadio.Add(etrainradio);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrainradio);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrainRadio etrainradio)
			{
				 //Update
				 db.EtrainRadio.Update(etrainradio);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrainRadio etrainradio)
			{
				 db.EtrainRadio.Remove(etrainradio);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
