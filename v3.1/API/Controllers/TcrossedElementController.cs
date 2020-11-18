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
	public class TcrossedElementsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TcrossedElement> lTcrossedElements = await db.TcrossedElement.GetAllCompanyTcrossedElements(id);
				 //return JsonConvert.SerializeObject(lTcrossedElements.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TcrossedElement tcrossedelement)
			{
				 //Create
				 db.TcrossedElement.Add(tcrossedelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcrossedelement);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TcrossedElement tcrossedelement)
			{
				 //Update
				 db.TcrossedElement.Update(tcrossedelement);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TcrossedElement tcrossedelement)
			{
				 db.TcrossedElement.Remove(tcrossedelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
