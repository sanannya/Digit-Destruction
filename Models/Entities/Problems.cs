using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ColumnAttribute = SQLite.ColumnAttribute;

namespace DigitDestruction.Models.Entities
{
    public class Problems
    {
        [PrimaryKey, AutoIncrement, Column("ProblemType")]
        public string ProblemType { get; set; }
        public int Digit1 { get; set; }
        public string Operation { get; set; }
        public int Digit2 { get; set; } 

    }
}
