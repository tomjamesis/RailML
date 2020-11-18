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
	public class TuniqueTrainKeysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TuniqueTrainKey> lTuniqueTrainKeys = await db.TuniqueTrainKey.GetAllCompanyTuniqueTrainKeys(id);
				 //return JsonConvert.SerializeObject(lTuniqueTrainKeys.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TuniqueTrainKey tuniquetrainkey)
			{
				 //Create
				 db.TuniqueTrainKey.Add(tuniquetrainkey);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tuniquetrainkey);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TuniqueTrainKey tuniquetrainkey)
			{
				 //Update
				 db.TuniqueTrainKey.Update(tuniquetrainkey);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TuniqueTrainKey tuniquetrainkey)
			{
				 db.TuniqueTrainKey.Remove(tuniquetrainkey);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
