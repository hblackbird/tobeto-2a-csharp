using Core.DataAccess;
using Core.Entities;

namespace DataAccess.Abstract;

public interface IUsersDal : IEntityRepository<User, int>
{

}
