using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitDestruction.Models.Entities;
using SQLite;

namespace DigitDestruction.Models.DataAccess
{
    public class ProblemsDatabase
    {
        SQLiteAsyncConnection Database;

        public ProblemsDatabase() 
        { 
        }
        
        async Task Init()
        {
            if (Database is not null) 
            {
                return;
            }

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<Problems>();
        }

        public async Task<List<Problems>> GetProblemsAsync()
        {
            await Init();
            return await Database.Table<Problems>().ToListAsync();
        }

        public async Task<List<Problems>> GetProblemsNotDoneAsync()
        {
            await Init();
            return await Database.Table<Problems>().Where(t => t.Done).ToListAsync();
        }

        public async Task<Problems> GetProblemsAsync(int id)
        {
            await Init();
            return await Database.Table<Problems>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveProblemsAsync(Problems problem)
        {
            await Init();
            if (problem.ID != 0)
                return await Database.UpdateAsync(problem);
            else
                return await Database.InsertAsync(problem);
        }

        public async Task<int> DeleteItemAsync(Problems problem)
        {
            await Init();
            return await Database.DeleteAsync(problem);
        }
    }
}
