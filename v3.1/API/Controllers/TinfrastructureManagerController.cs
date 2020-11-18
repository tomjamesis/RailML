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
	public class TinfrastructureManagersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TinfrastructureManager> lTinfrastructureManagers = await db.TinfrastructureManager.GetAllCompanyTinfrastructureManagers(id);
				 //return JsonConvert.SerializeObject(lTinfrastructureManagers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TinfrastructureManager tinfrastructuremanager)
			{
				 //Create
				 db.TinfrastructureManager.Add(tinfrastructuremanager);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tinfrastructuremanager);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TinfrastructureManager tinfrastructuremanager)
			{
				 //Update
				 db.TinfrastructureManager.Update(tinfrastructuremanager);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TinfrastructureManager tinfrastructuremanager)
			{
				 db.TinfrastructureManager.Remove(tinfrastructuremanager);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
