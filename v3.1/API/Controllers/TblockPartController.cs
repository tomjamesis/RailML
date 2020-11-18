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
	public class TblockPartsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TblockPart> lTblockParts = await db.TblockPart.GetAllCompanyTblockParts(id);
				 //return JsonConvert.SerializeObject(lTblockParts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TblockPart tblockpart)
			{
				 //Create
				 db.TblockPart.Add(tblockpart);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tblockpart);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TblockPart tblockpart)
			{
				 //Update
				 db.TblockPart.Update(tblockpart);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TblockPart tblockpart)
			{
				 db.TblockPart.Remove(tblockpart);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
