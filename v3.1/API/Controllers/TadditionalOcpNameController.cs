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
	public class TadditionalOcpNamesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TadditionalOcpName> lTadditionalOcpNames = await db.TadditionalOcpName.GetAllCompanyTadditionalOcpNames(id);
				 //return JsonConvert.SerializeObject(lTadditionalOcpNames.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TadditionalOcpName tadditionalocpname)
			{
				 //Create
				 db.TadditionalOcpName.Add(tadditionalocpname);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tadditionalocpname);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TadditionalOcpName tadditionalocpname)
			{
				 //Update
				 db.TadditionalOcpName.Update(tadditionalocpname);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TadditionalOcpName tadditionalocpname)
			{
				 db.TadditionalOcpName.Remove(tadditionalocpname);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
