using FoodJournal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodJournal.Api.Controllers
{
    [RoutePrefix("api/foodstuffnames")]
    public class FoodstuffNamesController : ApiController
    {
        private IFoodJournalService _service;
        
        public FoodstuffNamesController()
            : this(new FoodJournalService())
        { }
        public FoodstuffNamesController(IFoodJournalService service)
        {
            _service = service;
        }
        [Route("getall")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_service.GetFoodstuffNames());
        }


        [Route("find/{query}")]
        [HttpGet]
        public IHttpActionResult Find(string query)
        {
            return Ok(_service.GetFoodstuffNames(query));
        }

        #region IDisposable

        protected override void Dispose(bool disposing)
        {
            _service.Dispose();
            base.Dispose(disposing);
        }

        #endregion

    }
}
