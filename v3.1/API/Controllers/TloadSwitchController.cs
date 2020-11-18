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
	public class TloadSwitchsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TloadSwitch> lTloadSwitchs = await db.TloadSwitch.GetAllCompanyTloadSwitchs(id);
				 //return JsonConvert.SerializeObject(lTloadSwitchs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TloadSwitch tloadswitch)
			{
				 //Create
				 db.TloadSwitch.Add(tloadswitch);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tloadswitch);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TloadSwitch tloadswitch)
			{
				 //Update
				 db.TloadSwitch.Update(tloadswitch);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TloadSwitch tloadswitch)
			{
				 db.TloadSwitch.Remove(tloadswitch);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
