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
	public class EtrainPartSequencesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrainPartSequence> lEtrainPartSequences = await db.EtrainPartSequence.GetAllCompanyEtrainPartSequences(id);
				 //return JsonConvert.SerializeObject(lEtrainPartSequences.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrainPartSequence etrainpartsequence)
			{
				 //Create
				 db.EtrainPartSequence.Add(etrainpartsequence);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrainpartsequence);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrainPartSequence etrainpartsequence)
			{
				 //Update
				 db.EtrainPartSequence.Update(etrainpartsequence);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrainPartSequence etrainpartsequence)
			{
				 db.EtrainPartSequence.Remove(etrainpartsequence);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
