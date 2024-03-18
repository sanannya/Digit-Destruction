using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitDestruction.Models.Entities;
using SQLite;

namespace DigitDestruction.Models.DataAccess
{
    public class SQLiteImplementation
    {
        SQLiteAsyncConnection con;

        public SQLiteImplementation()
        {
            _ = InitializeDatabase();
        }

        private async Task InitializeDatabase()
        {
            if (con == null)
            {
                string fileName = DBaseNames.ProblemsDB;

                string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                string path = Path.Combine(documentPath, fileName);

                con = new SQLiteAsyncConnection(path);

                await con.CreateTableAsync<Problems>();
            }
        }

        public async Task<List<Problems>> GetProblems()
        {
            await IntializeDatabase();

            string sql = "SELECT * FROM Problem";

            List<Problems> problems = await con.QueryAsync<Problems>(sql);

            return problems;
        }

        //public async Task<bool> SaveProblems(Problems problems)
        //^fugure this out beirch
    }
}
