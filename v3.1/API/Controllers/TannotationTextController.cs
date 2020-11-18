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
	public class TannotationTextsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TannotationText> lTannotationTexts = await db.TannotationText.GetAllCompanyTannotationTexts(id);
				 //return JsonConvert.SerializeObject(lTannotationTexts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TannotationText tannotationtext)
			{
				 //Create
				 db.TannotationText.Add(tannotationtext);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tannotationtext);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TannotationText tannotationtext)
			{
				 //Update
				 db.TannotationText.Update(tannotationtext);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TannotationText tannotationtext)
			{
				 db.TannotationText.Remove(tannotationtext);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
