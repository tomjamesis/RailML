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
	public class EfourQuadrantChoppersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EfourQuadrantChopper> lEfourQuadrantChoppers = await db.EfourQuadrantChopper.GetAllCompanyEfourQuadrantChoppers(id);
				 //return JsonConvert.SerializeObject(lEfourQuadrantChoppers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EfourQuadrantChopper efourquadrantchopper)
			{
				 //Create
				 db.EfourQuadrantChopper.Add(efourquadrantchopper);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(efourquadrantchopper);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EfourQuadrantChopper efourquadrantchopper)
			{
				 //Update
				 db.EfourQuadrantChopper.Update(efourquadrantchopper);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EfourQuadrantChopper efourquadrantchopper)
			{
				 db.EfourQuadrantChopper.Remove(efourquadrantchopper);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
