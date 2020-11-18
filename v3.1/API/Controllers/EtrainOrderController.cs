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
	public class EtrainOrdersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrainOrder> lEtrainOrders = await db.EtrainOrder.GetAllCompanyEtrainOrders(id);
				 //return JsonConvert.SerializeObject(lEtrainOrders.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrainOrder etrainorder)
			{
				 //Create
				 db.EtrainOrder.Add(etrainorder);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrainorder);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrainOrder etrainorder)
			{
				 //Update
				 db.EtrainOrder.Update(etrainorder);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrainOrder etrainorder)
			{
				 db.EtrainOrder.Remove(etrainorder);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
