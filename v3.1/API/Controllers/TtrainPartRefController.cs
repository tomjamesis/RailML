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
	public class TtrainPartRefsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainPartRef> lTtrainPartRefs = await db.TtrainPartRef.GetAllCompanyTtrainPartRefs(id);
				 //return JsonConvert.SerializeObject(lTtrainPartRefs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainPartRef ttrainpartref)
			{
				 //Create
				 db.TtrainPartRef.Add(ttrainpartref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainpartref);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainPartRef ttrainpartref)
			{
				 //Update
				 db.TtrainPartRef.Update(ttrainpartref);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainPartRef ttrainpartref)
			{
				 db.TtrainPartRef.Remove(ttrainpartref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
