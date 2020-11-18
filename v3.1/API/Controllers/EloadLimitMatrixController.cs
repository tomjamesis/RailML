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
	public class EloadLimitMatrixsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EloadLimitMatrix> lEloadLimitMatrixs = await db.EloadLimitMatrix.GetAllCompanyEloadLimitMatrixs(id);
				 //return JsonConvert.SerializeObject(lEloadLimitMatrixs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EloadLimitMatrix eloadlimitmatrix)
			{
				 //Create
				 db.EloadLimitMatrix.Add(eloadlimitmatrix);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eloadlimitmatrix);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EloadLimitMatrix eloadlimitmatrix)
			{
				 //Update
				 db.EloadLimitMatrix.Update(eloadlimitmatrix);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EloadLimitMatrix eloadlimitmatrix)
			{
				 db.EloadLimitMatrix.Remove(eloadlimitmatrix);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
