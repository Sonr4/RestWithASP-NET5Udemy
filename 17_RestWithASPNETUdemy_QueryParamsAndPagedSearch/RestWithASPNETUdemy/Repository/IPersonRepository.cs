using RestWithASPNETErudio.Model;
using RestWithASPNETErudio.Repository;

namespace RestWithASPNETUdemy.Repository
{
    public interface IPersonRepository : IPersonRepository<Person>
    {
        Person Disable(long id);
        List<Person> FindByName(string firstName, string lastName);
    }
}
