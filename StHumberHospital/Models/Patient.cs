using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StHumberHospital.Models
{
    // the application core/logic and business layer for the patient test results

    [Table("tblTestResults")]
    public class Patient
    {
        [Key]
        [Column(Order = 1)]
        public int user_id { get; set; }
        public string document { get; set; }
        public DateTime? date { get; set; }
        public string description { get; set; }
        public string doctor_message { get; set; }

    }
}