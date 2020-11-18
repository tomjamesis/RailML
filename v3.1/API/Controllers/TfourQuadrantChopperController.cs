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
	public class TfourQuadrantChoppersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TfourQuadrantChopper> lTfourQuadrantChoppers = await db.TfourQuadrantChopper.GetAllCompanyTfourQuadrantChoppers(id);
				 //return JsonConvert.SerializeObject(lTfourQuadrantChoppers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TfourQuadrantChopper tfourquadrantchopper)
			{
				 //Create
				 db.TfourQuadrantChopper.Add(tfourquadrantchopper);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tfourquadrantchopper);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TfourQuadrantChopper tfourquadrantchopper)
			{
				 //Update
				 db.TfourQuadrantChopper.Update(tfourquadrantchopper);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TfourQuadrantChopper tfourquadrantchopper)
			{
				 db.TfourQuadrantChopper.Remove(tfourquadrantchopper);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
