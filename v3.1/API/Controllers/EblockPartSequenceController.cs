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
	public class EblockPartSequencesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EblockPartSequence> lEblockPartSequences = await db.EblockPartSequence.GetAllCompanyEblockPartSequences(id);
				 //return JsonConvert.SerializeObject(lEblockPartSequences.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EblockPartSequence eblockpartsequence)
			{
				 //Create
				 db.EblockPartSequence.Add(eblockpartsequence);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eblockpartsequence);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EblockPartSequence eblockpartsequence)
			{
				 //Update
				 db.EblockPartSequence.Update(eblockpartsequence);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EblockPartSequence eblockpartsequence)
			{
				 db.EblockPartSequence.Remove(eblockpartsequence);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
