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
	public class TloadLimitMatrixTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TloadLimitMatrixType> lTloadLimitMatrixTypes = await db.TloadLimitMatrixType.GetAllCompanyTloadLimitMatrixTypes(id);
				 //return JsonConvert.SerializeObject(lTloadLimitMatrixTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TloadLimitMatrixType tloadlimitmatrixtype)
			{
				 //Create
				 db.TloadLimitMatrixType.Add(tloadlimitmatrixtype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tloadlimitmatrixtype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TloadLimitMatrixType tloadlimitmatrixtype)
			{
				 //Update
				 db.TloadLimitMatrixType.Update(tloadlimitmatrixtype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TloadLimitMatrixType tloadlimitmatrixtype)
			{
				 db.TloadLimitMatrixType.Remove(tloadlimitmatrixtype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
