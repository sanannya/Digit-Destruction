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
    [SQLite.Table("problems")]
    public class Problems
    {
        [PrimaryKey, AutoIncrement, Column("index")]
        public int probNum { get; set; }

        [MaxLength(100), Unique]
        public string problemQ { get; set; }

    }
}
