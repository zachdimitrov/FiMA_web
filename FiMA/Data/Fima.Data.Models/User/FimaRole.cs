namespace Fima.Data.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;

    public class FimaRole : IdentityRole<int, FimaUserRole>
    {
        public FimaRole()
        {
        }

        public FimaRole(string name)
        {
            this.Name = name;
        }
    }
}
