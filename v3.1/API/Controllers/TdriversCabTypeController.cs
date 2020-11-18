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
	public class TdriversCabTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TdriversCabType> lTdriversCabTypes = await db.TdriversCabType.GetAllCompanyTdriversCabTypes(id);
				 //return JsonConvert.SerializeObject(lTdriversCabTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TdriversCabType tdriverscabtype)
			{
				 //Create
				 db.TdriversCabType.Add(tdriverscabtype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tdriverscabtype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TdriversCabType tdriverscabtype)
			{
				 //Update
				 db.TdriversCabType.Update(tdriverscabtype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TdriversCabType tdriverscabtype)
			{
				 db.TdriversCabType.Remove(tdriverscabtype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
