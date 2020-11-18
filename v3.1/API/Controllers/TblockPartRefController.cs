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
	public class TblockPartRefsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TblockPartRef> lTblockPartRefs = await db.TblockPartRef.GetAllCompanyTblockPartRefs(id);
				 //return JsonConvert.SerializeObject(lTblockPartRefs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TblockPartRef tblockpartref)
			{
				 //Create
				 db.TblockPartRef.Add(tblockpartref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tblockpartref);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TblockPartRef tblockpartref)
			{
				 //Update
				 db.TblockPartRef.Update(tblockpartref);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TblockPartRef tblockpartref)
			{
				 db.TblockPartRef.Remove(tblockpartref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
