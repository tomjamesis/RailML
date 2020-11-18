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
	public class TbaliseLinkReactionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TbaliseLinkReaction> lTbaliseLinkReactions = await db.TbaliseLinkReaction.GetAllCompanyTbaliseLinkReactions(id);
				 //return JsonConvert.SerializeObject(lTbaliseLinkReactions.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TbaliseLinkReaction tbaliselinkreaction)
			{
				 //Create
				 db.TbaliseLinkReaction.Add(tbaliselinkreaction);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tbaliselinkreaction);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TbaliseLinkReaction tbaliselinkreaction)
			{
				 //Update
				 db.TbaliseLinkReaction.Update(tbaliselinkreaction);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TbaliseLinkReaction tbaliselinkreaction)
			{
				 db.TbaliseLinkReaction.Remove(tbaliselinkreaction);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
