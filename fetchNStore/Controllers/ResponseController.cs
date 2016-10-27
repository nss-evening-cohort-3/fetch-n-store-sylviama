﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using fetchNStore.DAL;
using fetchNStore.Models;

namespace fetchNStore.Controllers
{
    public class ResponseController : ApiController
    {
        // GET api/<controller>
        public List<Response> Get()
        {
            ResponseRepository repo = new ResponseRepository();
            return repo.GetResponse();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        //change data type into dynamic, so that it could be JSON
        public void Post([FromBody]dynamic value)
        {
            ResponseRepository repo = new ResponseRepository();
            repo.SaveResponse(value.Value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}