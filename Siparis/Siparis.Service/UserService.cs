using Siparis.Data;
using Siparis.Data.Model;
using Siparis.Data.Repositories;
using Siparis.Data.UnitOfWork;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Siparis.Data.Context;

namespace Siparis.Service
{
    public class UserService
    {
        private SiparisContext _dbContext;
        private IUnitOfWork _uow;
        private IRepository<Users> _userRepository;
        private static UserService _instance;

        private UserService(){
            _dbContext = new SiparisContext();
            _uow = new UnitOfWork(_dbContext);
            _userRepository = Repository<Users>.GetInstance(_dbContext);
        }

        public static UserService GetInstance()
        {
            if(_instance == null)
            {
                _instance = new UserService();
            }
            return _instance;
        }

        public async Task<IEnumerable<Users>> GetUsers()
        {
            return await _userRepository.GetAll();
        }

        public async Task<bool> AddUser(Users _user)
        {
            await _userRepository.Add(_user);
            int id = await _uow.SaveChanges();
            if (id == 1)
            {
                return true;
            }
            return false;
        }
    }
}
