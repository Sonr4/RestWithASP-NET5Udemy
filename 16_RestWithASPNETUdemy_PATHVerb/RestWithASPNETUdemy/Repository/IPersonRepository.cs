using Microsoft.AspNetCore.Mvc;
using RestWithASPNETErudio.Model;
using RestWithASPNETErudio.Repository;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Repository
{
    public interface IPersonRepository : IPersonRepository<Person>
    {
        Person Disable(long id);
    }
}
