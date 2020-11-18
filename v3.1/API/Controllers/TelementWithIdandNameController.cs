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
	public class TelementWithIdandNamesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TelementWithIdandName> lTelementWithIdandNames = await db.TelementWithIdandName.GetAllCompanyTelementWithIdandNames(id);
				 //return JsonConvert.SerializeObject(lTelementWithIdandNames.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TelementWithIdandName telementwithidandname)
			{
				 //Create
				 db.TelementWithIdandName.Add(telementwithidandname);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(telementwithidandname);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TelementWithIdandName telementwithidandname)
			{
				 //Update
				 db.TelementWithIdandName.Update(telementwithidandname);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TelementWithIdandName telementwithidandname)
			{
				 db.TelementWithIdandName.Remove(telementwithidandname);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
