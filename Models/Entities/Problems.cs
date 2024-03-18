using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DigitDestruction.Models.Entities
{
    public class Problems
    {
        [PrimaryKey, AutoIncrement, Column("ProblemType")]
        public string ProblemType { get; set; }

    }
}
