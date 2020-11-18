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
	public class ElementContainersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<ElementContainer> lElementContainers = await db.ElementContainer.GetAllCompanyElementContainers(id);
				 //return JsonConvert.SerializeObject(lElementContainers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]ElementContainer elementcontainer)
			{
				 //Create
				 db.ElementContainer.Add(elementcontainer);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(elementcontainer);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]ElementContainer elementcontainer)
			{
				 //Update
				 db.ElementContainer.Update(elementcontainer);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]ElementContainer elementcontainer)
			{
				 db.ElementContainer.Remove(elementcontainer);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
