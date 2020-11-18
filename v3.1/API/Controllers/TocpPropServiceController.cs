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
	public class TocpPropServicesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TocpPropService> lTocpPropServices = await db.TocpPropService.GetAllCompanyTocpPropServices(id);
				 //return JsonConvert.SerializeObject(lTocpPropServices.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TocpPropService tocppropservice)
			{
				 //Create
				 db.TocpPropService.Add(tocppropservice);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tocppropservice);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TocpPropService tocppropservice)
			{
				 //Update
				 db.TocpPropService.Update(tocppropservice);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TocpPropService tocppropservice)
			{
				 db.TocpPropService.Remove(tocppropservice);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
