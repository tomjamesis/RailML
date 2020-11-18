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
	public class TepsgCodesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TepsgCode> lTepsgCodes = await db.TepsgCode.GetAllCompanyTepsgCodes(id);
				 //return JsonConvert.SerializeObject(lTepsgCodes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TepsgCode tepsgcode)
			{
				 //Create
				 db.TepsgCode.Add(tepsgcode);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tepsgcode);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TepsgCode tepsgcode)
			{
				 //Update
				 db.TepsgCode.Update(tepsgcode);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TepsgCode tepsgcode)
			{
				 db.TepsgCode.Remove(tepsgcode);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
