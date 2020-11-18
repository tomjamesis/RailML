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
	public class TcategorysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tcategory> lTcategorys = await db.Tcategory.GetAllCompanyTcategorys(id);
				 //return JsonConvert.SerializeObject(lTcategorys.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tcategory tcategory)
			{
				 //Create
				 db.Tcategory.Add(tcategory);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcategory);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tcategory tcategory)
			{
				 //Update
				 db.Tcategory.Update(tcategory);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tcategory tcategory)
			{
				 db.Tcategory.Remove(tcategory);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
