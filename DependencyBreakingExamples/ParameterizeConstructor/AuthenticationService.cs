using System.Data.Entity;
using System.Security.Authentication;

namespace DependencyBreakingExamples.ParameterizeConstructor
{
    public class AuthenticationService
    {
        private readonly UserRepository userRepository;

        public AuthenticationService()
        {
            var dbContext = new DbContext("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword; ");
            userRepository = new UserRepository(dbContext);
        }

        public void Authenticate(string login, string password)
        {
            var user = userRepository.FindByLoginAndPass(login, password);

            if (user == null)
            {
                throw new AuthenticationException("Invalid login or password!");
            }

            if (!user.Active)
            {
                throw new AuthenticationException("User is blocked!");
            }
        }
    }

    public class User
    {
        public bool Active { get; set; }
    }

    public class UserRepository
    {
        private readonly DbContext dbContext;

        public UserRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            dbContext.Database.CreateIfNotExists();
        }

        public User FindByLoginAndPass(string login, string password)
        {
            return new User();
        }
    }
}