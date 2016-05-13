using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StHumberHospital.Models
{
    public class CalendarContext : DbContext 
    {

        // the application core/logic and business layer for the appointment booking calendar 

        public CalendarContext() : base("SQLConnectionString")
            {
                Database.SetInitializer(new CreateDatabaseIfNotExists<CalendarContext>());
            }
            public System.Data.Entity.DbSet<StHumberHospital.Models.Appointment> Appointments { get; set; }
        }

}