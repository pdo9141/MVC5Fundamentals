using PatientData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PatientData.Controllers
{
    [Authorize]
    public class PatientsController : ApiController
    {        
        public IEnumerable<Patient> Get()
        {
            return PatientDb.FindAll();
        }

        /// <summary>
        /// This is the old way, don't do this now, return IHttpActionResult instead of HttpResponseMessage
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HttpResponseMessage Get(string id)
        {
            var patients = PatientDb.FindAll();
            var patient = patients.FirstOrDefault(p => p.Id.Equals(id));
            if (patient == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Patient not found");
            
            return Request.CreateResponse(patient);            
        }

        [Route("api/patients/{id}/medications")]
        public IHttpActionResult GetMedications(string id)
        {
            var patients = PatientDb.FindAll();
            var patient = patients.FirstOrDefault(p => p.Id.Equals(id));
            if (patient == null)
                return NotFound();

            return Ok(patient.Medications);
        }
    }
}
