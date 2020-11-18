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
	public class TocpWithIdandNamesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TocpWithIdandName> lTocpWithIdandNames = await db.TocpWithIdandName.GetAllCompanyTocpWithIdandNames(id);
				 //return JsonConvert.SerializeObject(lTocpWithIdandNames.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TocpWithIdandName tocpwithidandname)
			{
				 //Create
				 db.TocpWithIdandName.Add(tocpwithidandname);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tocpwithidandname);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TocpWithIdandName tocpwithidandname)
			{
				 //Update
				 db.TocpWithIdandName.Update(tocpwithidandname);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TocpWithIdandName tocpwithidandname)
			{
				 db.TocpWithIdandName.Remove(tocpwithidandname);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
