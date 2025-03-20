using ProjectP.DataAccess.Interfaces;
using ProjectP.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectP.DataAccess
{
    internal class MembersEventRepository(AppContext appContext) : IMembersEventRepository
    {
        public async Task CreateAsync(MembersEvent membersEvent, CancellationToken cancellationToken = default)
        {
            await appContext.MembersEvents.AddAsync(membersEvent, cancellationToken);
            await appContext.SaveChangesAsync(cancellationToken);
        }
    }
}
