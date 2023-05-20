using WebbAPP.Contexts;
using WebbAPP.Models.Entities;

namespace WebbAPP.Helpers.Repositories;

public class ContactFormRepo : Repo<ContactFormEntity>
{
    public ContactFormRepo(DataContext context) : base(context)
    {
    }
}
