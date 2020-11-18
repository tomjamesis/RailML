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
	public class TtrainPartSequencesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainPartSequence> lTtrainPartSequences = await db.TtrainPartSequence.GetAllCompanyTtrainPartSequences(id);
				 //return JsonConvert.SerializeObject(lTtrainPartSequences.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainPartSequence ttrainpartsequence)
			{
				 //Create
				 db.TtrainPartSequence.Add(ttrainpartsequence);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainpartsequence);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainPartSequence ttrainpartsequence)
			{
				 //Update
				 db.TtrainPartSequence.Update(ttrainpartsequence);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainPartSequence ttrainpartsequence)
			{
				 db.TtrainPartSequence.Remove(ttrainpartsequence);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
