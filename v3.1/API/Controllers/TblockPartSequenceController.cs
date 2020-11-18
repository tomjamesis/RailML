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
	public class TblockPartSequencesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TblockPartSequence> lTblockPartSequences = await db.TblockPartSequence.GetAllCompanyTblockPartSequences(id);
				 //return JsonConvert.SerializeObject(lTblockPartSequences.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TblockPartSequence tblockpartsequence)
			{
				 //Create
				 db.TblockPartSequence.Add(tblockpartsequence);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tblockpartsequence);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TblockPartSequence tblockpartsequence)
			{
				 //Update
				 db.TblockPartSequence.Update(tblockpartsequence);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TblockPartSequence tblockpartsequence)
			{
				 db.TblockPartSequence.Remove(tblockpartsequence);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
