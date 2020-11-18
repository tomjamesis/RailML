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
	public class TvalueTableValueLineValuessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TvalueTableValueLineValues> lTvalueTableValueLineValuess = await db.TvalueTableValueLineValues.GetAllCompanyTvalueTableValueLineValuess(id);
				 //return JsonConvert.SerializeObject(lTvalueTableValueLineValuess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TvalueTableValueLineValues tvaluetablevaluelinevalues)
			{
				 //Create
				 db.TvalueTableValueLineValues.Add(tvaluetablevaluelinevalues);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tvaluetablevaluelinevalues);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TvalueTableValueLineValues tvaluetablevaluelinevalues)
			{
				 //Update
				 db.TvalueTableValueLineValues.Update(tvaluetablevaluelinevalues);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TvalueTableValueLineValues tvaluetablevaluelinevalues)
			{
				 db.TvalueTableValueLineValues.Remove(tvaluetablevaluelinevalues);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
