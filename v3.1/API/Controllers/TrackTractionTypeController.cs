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
	public class TrackTractionTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TrackTractionType> lTrackTractionTypes = await db.TrackTractionType.GetAllCompanyTrackTractionTypes(id);
				 //return JsonConvert.SerializeObject(lTrackTractionTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TrackTractionType tracktractiontype)
			{
				 //Create
				 db.TrackTractionType.Add(tracktractiontype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tracktractiontype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TrackTractionType tracktractiontype)
			{
				 //Update
				 db.TrackTractionType.Update(tracktractiontype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TrackTractionType tracktractiontype)
			{
				 db.TrackTractionType.Remove(tracktractiontype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
