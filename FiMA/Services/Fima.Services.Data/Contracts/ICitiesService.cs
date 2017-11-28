namespace Fima.Services.Data.Contracts
{
    using System.Collections.Generic;

    public interface ICitiesService
    {
        IEnumerable<string> AllNames();
    }
}
