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
	public class TmacroscopicNodesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TmacroscopicNode> lTmacroscopicNodes = await db.TmacroscopicNode.GetAllCompanyTmacroscopicNodes(id);
				 //return JsonConvert.SerializeObject(lTmacroscopicNodes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TmacroscopicNode tmacroscopicnode)
			{
				 //Create
				 db.TmacroscopicNode.Add(tmacroscopicnode);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tmacroscopicnode);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TmacroscopicNode tmacroscopicnode)
			{
				 //Update
				 db.TmacroscopicNode.Update(tmacroscopicnode);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TmacroscopicNode tmacroscopicnode)
			{
				 db.TmacroscopicNode.Remove(tmacroscopicnode);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
