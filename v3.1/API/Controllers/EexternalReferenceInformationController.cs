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
	public class EexternalReferenceInformationsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EexternalReferenceInformation> lEexternalReferenceInformations = await db.EexternalReferenceInformation.GetAllCompanyEexternalReferenceInformations(id);
				 //return JsonConvert.SerializeObject(lEexternalReferenceInformations.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EexternalReferenceInformation eexternalreferenceinformation)
			{
				 //Create
				 db.EexternalReferenceInformation.Add(eexternalreferenceinformation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eexternalreferenceinformation);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EexternalReferenceInformation eexternalreferenceinformation)
			{
				 //Update
				 db.EexternalReferenceInformation.Update(eexternalreferenceinformation);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EexternalReferenceInformation eexternalreferenceinformation)
			{
				 db.EexternalReferenceInformation.Remove(eexternalreferenceinformation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
