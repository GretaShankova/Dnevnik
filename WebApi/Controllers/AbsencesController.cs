﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Data;
using Data.Models;

namespace WebApi.Controllers
{
    public class AbsencesController : ApiController
    {
        private AppDbContext db = new AppDbContext();

        // GET: api/Absences
        public IQueryable<Absence> GetAbsences()
        {
            return db.Absences;
        }

        // GET: api/Absences/5
        [ResponseType(typeof(Absence))]
        public IHttpActionResult GetAbsence(int id)
        {
            Absence absence = db.Absences.Find(id);
            if (absence == null)
            {
                return NotFound();
            }

            return Ok(absence);
        }

        // PUT: api/Absences/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAbsence(int id, Absence absence)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != absence.Id)
            {
                return BadRequest();
            }

            db.Entry(absence).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AbsenceExists(id))
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

        // POST: api/Absences
        [ResponseType(typeof(Absence))]
        public IHttpActionResult PostAbsence(Absence absence)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Absences.Add(absence);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = absence.Id }, absence);
        }

        // DELETE: api/Absences/5
        [ResponseType(typeof(Absence))]
        public IHttpActionResult DeleteAbsence(int id)
        {
            Absence absence = db.Absences.Find(id);
            if (absence == null)
            {
                return NotFound();
            }

            db.Absences.Remove(absence);
            db.SaveChanges();

            return Ok(absence);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AbsenceExists(int id)
        {
            return db.Absences.Count(e => e.Id == id) > 0;
        }
    }
}