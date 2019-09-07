using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Employee.Models;

namespace Employee.Controllers
{
    public class EmploysController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Employs
        public IQueryable<Employ> GetEmploys()
        {
            return db.Employs;
        }

        // GET: api/Employs/5
        [ResponseType(typeof(Employ))]
        public IHttpActionResult GetEmploy(int id)
        {
            Employ employ = db.Employs.Find(id);
            if (employ == null)
            {
                return NotFound();
            }

            return Ok(employ);
        }

        // PUT: api/Employs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmploy(int id, Employ employ)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employ.EmployeeID)
            {
                return BadRequest();
            }

            db.Entry(employ).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employs
        [ResponseType(typeof(Employ))]
        public IHttpActionResult PostEmploy(Employ employ)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Employs.Add(employ);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employ.EmployeeID }, employ);
        }

        // DELETE: api/Employs/5
        [ResponseType(typeof(Employ))]
        public IHttpActionResult DeleteEmploy(int id)
        {
            Employ employ = db.Employs.Find(id);
            if (employ == null)
            {
                return NotFound();
            }

            db.Employs.Remove(employ);
            db.SaveChanges();

            return Ok(employ);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployExists(int id)
        {
            return db.Employs.Count(e => e.EmployeeID == id) > 0;
        }
    }
}