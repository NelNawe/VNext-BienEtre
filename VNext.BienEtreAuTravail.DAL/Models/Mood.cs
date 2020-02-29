using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNext.BienEtreAuTravail.DAL.Models.Database
{
    public class Mood
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MoodId { get; set; }
        public int State { get; set; }
        public DateTime Created_at { get; set; }
        IList<HumeurEmployee> HumeurEmployee { get; set; }
    }
}