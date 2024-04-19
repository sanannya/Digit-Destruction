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
        public string probText;

        public Problems(string prob)
        {
            probText = prob;
        }

        public static List<Problems> GetDivProbs()
        {
            return new List<Problems>
            {
                new Problems("10/2"),
                new Problems("12/3"),
                new Problems("20/5")
            };
        }

        public string getProbText { get; set; }
    }
    
}