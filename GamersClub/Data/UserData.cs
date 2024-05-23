using GamersClub.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamersClub.Data
{
    public class UserData
    {
        private SQLiteAsyncConnection _conexaoDB;

        public UserData(SQLiteAsyncConnection conexaoDB)
        {
            _conexaoDB = conexaoDB;
        }

        public Task<List<UserModel>> GetUsers()
        {
            var Lista = _conexaoDB
                .Table<UserModel>()
                .ToListAsync();

            return Lista;

        }

        public Task<UserModel> GetItenUser(string email, string password)
        {
            var user = _conexaoDB
                .Table<UserModel>()
                .Where(u => u.Email == email && u.Password == password)
                .FirstOrDefaultAsync();

            return user;

        }

        public Task<UserModel> GetIdUser(Guid id)
        {
            var user = _conexaoDB
                .Table<UserModel>()
                .Where(u => u.Id == id)
                .FirstOrDefaultAsync();

            return user;

        }

        public async Task<int> SaveUser(UserModel user)
        {
            var newUser = await GetIdUser(user.Id);
            if (newUser == null)
            {
                return await _conexaoDB.InsertAsync(user);
            }
            else
            {
                return await _conexaoDB.UpdateAsync(user);
            }
        }

        public async Task<int> deletarUsuario(UserModel user)
        {
            return await _conexaoDB.DeleteAsync(user);
        }
    }
}
