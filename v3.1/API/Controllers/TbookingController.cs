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
	public class TbookingsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tbooking> lTbookings = await db.Tbooking.GetAllCompanyTbookings(id);
				 //return JsonConvert.SerializeObject(lTbookings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tbooking tbooking)
			{
				 //Create
				 db.Tbooking.Add(tbooking);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tbooking);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tbooking tbooking)
			{
				 //Update
				 db.Tbooking.Update(tbooking);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tbooking tbooking)
			{
				 db.Tbooking.Remove(tbooking);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
