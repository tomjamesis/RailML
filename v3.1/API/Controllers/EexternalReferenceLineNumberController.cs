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
	public class EexternalReferenceLineNumbersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EexternalReferenceLineNumber> lEexternalReferenceLineNumbers = await db.EexternalReferenceLineNumber.GetAllCompanyEexternalReferenceLineNumbers(id);
				 //return JsonConvert.SerializeObject(lEexternalReferenceLineNumbers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EexternalReferenceLineNumber eexternalreferencelinenumber)
			{
				 //Create
				 db.EexternalReferenceLineNumber.Add(eexternalreferencelinenumber);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eexternalreferencelinenumber);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EexternalReferenceLineNumber eexternalreferencelinenumber)
			{
				 //Update
				 db.EexternalReferenceLineNumber.Update(eexternalreferencelinenumber);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EexternalReferenceLineNumber eexternalreferencelinenumber)
			{
				 db.EexternalReferenceLineNumber.Remove(eexternalreferencelinenumber);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
