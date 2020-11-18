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
	public class TtrackNodesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrackNode> lTtrackNodes = await db.TtrackNode.GetAllCompanyTtrackNodes(id);
				 //return JsonConvert.SerializeObject(lTtrackNodes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrackNode ttracknode)
			{
				 //Create
				 db.TtrackNode.Add(ttracknode);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttracknode);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrackNode ttracknode)
			{
				 //Update
				 db.TtrackNode.Update(ttracknode);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrackNode ttracknode)
			{
				 db.TtrackNode.Remove(ttracknode);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
