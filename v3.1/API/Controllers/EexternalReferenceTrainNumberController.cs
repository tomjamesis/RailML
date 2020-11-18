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
	public class EexternalReferenceTrainNumbersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EexternalReferenceTrainNumber> lEexternalReferenceTrainNumbers = await db.EexternalReferenceTrainNumber.GetAllCompanyEexternalReferenceTrainNumbers(id);
				 //return JsonConvert.SerializeObject(lEexternalReferenceTrainNumbers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EexternalReferenceTrainNumber eexternalreferencetrainnumber)
			{
				 //Create
				 db.EexternalReferenceTrainNumber.Add(eexternalreferencetrainnumber);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eexternalreferencetrainnumber);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EexternalReferenceTrainNumber eexternalreferencetrainnumber)
			{
				 //Update
				 db.EexternalReferenceTrainNumber.Update(eexternalreferencetrainnumber);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EexternalReferenceTrainNumber eexternalreferencetrainnumber)
			{
				 db.EexternalReferenceTrainNumber.Remove(eexternalreferencetrainnumber);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
