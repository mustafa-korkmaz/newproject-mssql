using DAL.Models;

namespace DAL.Configuration
{
    public class ContextCreator
    {
        private readonly YodaDbContext _db = new YodaDbContext();

        public void CreateDb()
        { // this insertion will trigger db schema creation
          //TestCodeFirstModel model = _db.TestsFirstModels.Single(p => p.Name == "helloworld");
            var user = new ApplicationUser() { UserName = "m.korkmaz@outlook.com", Email = "m.korkmaz@outlook.com",PasswordHash = "ALhHm71RAfbF7FnARnYYZWIfC63wNp+0cbyYB5SOHi+btq9ESvUk4JV1tRICiQnr1A==" }; //Mk_x1

            _db.Users.Add(user);
            _db.SaveChanges();
        }
    }
}
