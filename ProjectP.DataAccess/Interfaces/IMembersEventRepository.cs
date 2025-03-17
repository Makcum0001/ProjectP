using ProjectP.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectP.DataAccess.Interfaces
{
    public interface IMembersEventRepository
    {
        Task CreateAsync(MembersEvent membersEvent, CancellationToken cancellationToken = default);
    }
}
