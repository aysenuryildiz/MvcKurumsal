﻿using Project.Http.Helpers;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.Http.Controllers
{
    [Route("http/{action}")]
    public class HomeController : BaseController
    {

        Domain.PersonelDataService dataService = new Domain.PersonelDataService();


        [HttpGet , AllowAnonymous]
        public HttpResponseMessage GetPersonelDataList()
        {
            var list = dataService.GetDataList();
            return Request.CreateResponse(HttpStatusCode.OK,list);
        }
    }
}
