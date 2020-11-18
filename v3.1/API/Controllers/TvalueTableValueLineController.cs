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
	public class TvalueTableValueLinesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TvalueTableValueLine> lTvalueTableValueLines = await db.TvalueTableValueLine.GetAllCompanyTvalueTableValueLines(id);
				 //return JsonConvert.SerializeObject(lTvalueTableValueLines.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TvalueTableValueLine tvaluetablevalueline)
			{
				 //Create
				 db.TvalueTableValueLine.Add(tvaluetablevalueline);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tvaluetablevalueline);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TvalueTableValueLine tvaluetablevalueline)
			{
				 //Update
				 db.TvalueTableValueLine.Update(tvaluetablevalueline);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TvalueTableValueLine tvaluetablevalueline)
			{
				 db.TvalueTableValueLine.Remove(tvaluetablevalueline);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
