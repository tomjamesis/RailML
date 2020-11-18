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
	public class TsignalTrainRadiosController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TsignalTrainRadio> lTsignalTrainRadios = await db.TsignalTrainRadio.GetAllCompanyTsignalTrainRadios(id);
				 //return JsonConvert.SerializeObject(lTsignalTrainRadios.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TsignalTrainRadio tsignaltrainradio)
			{
				 //Create
				 db.TsignalTrainRadio.Add(tsignaltrainradio);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tsignaltrainradio);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TsignalTrainRadio tsignaltrainradio)
			{
				 //Update
				 db.TsignalTrainRadio.Update(tsignaltrainradio);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TsignalTrainRadio tsignaltrainradio)
			{
				 db.TsignalTrainRadio.Remove(tsignaltrainradio);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
