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
	public class TglobalElementWithMetadatasController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TglobalElementWithMetadata> lTglobalElementWithMetadatas = await db.TglobalElementWithMetadata.GetAllCompanyTglobalElementWithMetadatas(id);
				 //return JsonConvert.SerializeObject(lTglobalElementWithMetadatas.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TglobalElementWithMetadata tglobalelementwithmetadata)
			{
				 //Create
				 db.TglobalElementWithMetadata.Add(tglobalelementwithmetadata);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tglobalelementwithmetadata);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TglobalElementWithMetadata tglobalelementwithmetadata)
			{
				 //Update
				 db.TglobalElementWithMetadata.Update(tglobalelementwithmetadata);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TglobalElementWithMetadata tglobalelementwithmetadata)
			{
				 db.TglobalElementWithMetadata.Remove(tglobalelementwithmetadata);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
