using Core.CrossCuttingConcerns.Exceptions;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.BusinessRules;

public class UsersRules
{
    private readonly IUsersDal _userDal;

    public UsersRules(IUsersDal userDal)
    {
        _userDal = userDal;
    }

    public void CheckIfUserNoExists(int id)
    {
        bool isExists = _userDal.GetList().Any(a => a.Id == id);
        if (!isExists)
        {
            throw new BusinessException("This id not found");
        }
    }

    public User FindId(int id)
    {
        User user = _userDal.GetList().Where(a => a.Id == id).FirstOrDefault();
        return user;
    }

}
