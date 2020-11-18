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
	public class EtrainPartssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrainParts> lEtrainPartss = await db.EtrainParts.GetAllCompanyEtrainPartss(id);
				 //return JsonConvert.SerializeObject(lEtrainPartss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrainParts etrainparts)
			{
				 //Create
				 db.EtrainParts.Add(etrainparts);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrainparts);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrainParts etrainparts)
			{
				 //Update
				 db.EtrainParts.Update(etrainparts);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrainParts etrainparts)
			{
				 db.EtrainParts.Remove(etrainparts);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
