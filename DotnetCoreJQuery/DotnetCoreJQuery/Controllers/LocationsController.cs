using DotnetCoreJQuery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreJQuery.Controllers
{
    public class LocationsController : Controller
    {
        // GET: LocationsController
        public ActionResult Index()
        {
            CitiesInfo model = new CitiesInfo();
            //model.CountryInfoList.Add(new CountryInfo { CId = 0, CName = "Select country" });
            model.CountryInfoList.Add(new CountryInfo { CId = 101, CName = "India" });
            model.CountryInfoList.Add(new CountryInfo { CId = 102, CName = "Nepal" });
            model.CountryInfoList.Add(new CountryInfo { CId = 103, CName = "Shrilanka" });
            model.CountryInfoList.Add(new CountryInfo { CId = 104, CName = "Chaina" });
            model.CountryInfoList.Add(new CountryInfo { CId = 105, CName = "England" });


            return View(model);
        }

        [HttpPost]
        public ActionResult StateData(int cid)
        {
            List<StateInfo> states = new List<StateInfo>()
            {
                new StateInfo (){SId=101,CId=101, SName="Bihar"},
                new StateInfo (){SId=102,CId=101, SName="UP"},
                new StateInfo (){SId=103,CId=101, SName="Punjab"},
                new StateInfo (){SId=104,CId=101, SName="MP"},
                new StateInfo (){SId=105,CId=101, SName="Delhi"},
                new StateInfo (){SId=106,CId=102, SName="Khatmandu"},
                new StateInfo (){SId=107,CId=102, SName="Jankpur"},
                new StateInfo (){SId=108,CId=103, SName="Jakarta"},
                new StateInfo (){SId=109,CId=104, SName="Bijing"},
                new StateInfo (){SId=110,CId=105, SName="London"}
            };

            CitiesInfo model = new CitiesInfo();
            model.StateInfoList = states.Where(s => s.CId == cid).ToList();
            
            return Json(model);

        }


        [HttpPost]
        public ActionResult CityData(int sid)
        {
            List<CityInfo> cites = new List<CityInfo>()
            {
                new CityInfo (){CityId=101, SId=101, CityName="Darbhanga"},
                new CityInfo (){CityId=101, SId=102, CityName="Lucknow"},
                new CityInfo (){CityId=101, SId=103, CityName="Amritsar"},
                new CityInfo (){CityId=101, SId=104, CityName="Bhopal"},
                new CityInfo (){CityId=101, SId=105, CityName="Delhi"},
                new CityInfo (){CityId=102, SId=106, CityName="Khatmandu"},
                new CityInfo (){CityId=102, SId=107, CityName="Jankpur"},
                new CityInfo (){CityId=103, SId=108, CityName="Jakarta"},
                new CityInfo (){CityId=104, SId=109, CityName="Bijing"},
                new CityInfo (){CityId=105, SId=110, CityName="London"}
            };

            CitiesInfo model = new CitiesInfo();
            model.CityInfoList = cites.Where(s => s.SId == sid).ToList();

            return Json(model);

        }
    }
}
