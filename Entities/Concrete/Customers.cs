
using Core.Entities;

namespace Entities.Concrete;

public class Customers: Entity<int>
{
    public int UserId {  get; set; }
    public User User { get; set; }

    public Customers() { }

    public Customers(User? user,int userid)
    {
        UserId = userid;
        User = user;
    }
}
