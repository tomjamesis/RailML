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
	public class EtrackNodesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrackNode> lEtrackNodes = await db.EtrackNode.GetAllCompanyEtrackNodes(id);
				 //return JsonConvert.SerializeObject(lEtrackNodes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrackNode etracknode)
			{
				 //Create
				 db.EtrackNode.Add(etracknode);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etracknode);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrackNode etracknode)
			{
				 //Update
				 db.EtrackNode.Update(etracknode);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrackNode etracknode)
			{
				 db.EtrackNode.Remove(etracknode);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
