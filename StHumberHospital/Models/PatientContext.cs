using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StHumberHospital.Models
{
    // the application core/logic and business layer for the patient test results
    //this establishes the database for this component

    public class PatientContext:DbContext
    {
        public DbSet<Patient> Patients { get; set; }
    }
}