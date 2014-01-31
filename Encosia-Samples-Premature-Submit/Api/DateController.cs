using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Encosia_Samples_Premature_Submit.Api {
  public class DateController : ApiController {
    public string Get() {
      return DateTime.Now.ToString();
    }

    public string Get(DateTime date) {
      return date.ToShortDateString();
    }
  }
}