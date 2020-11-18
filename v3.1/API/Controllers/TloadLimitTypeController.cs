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
	public class TloadLimitTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TloadLimitType> lTloadLimitTypes = await db.TloadLimitType.GetAllCompanyTloadLimitTypes(id);
				 //return JsonConvert.SerializeObject(lTloadLimitTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TloadLimitType tloadlimittype)
			{
				 //Create
				 db.TloadLimitType.Add(tloadlimittype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tloadlimittype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TloadLimitType tloadlimittype)
			{
				 //Update
				 db.TloadLimitType.Update(tloadlimittype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TloadLimitType tloadlimittype)
			{
				 db.TloadLimitType.Remove(tloadlimittype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
