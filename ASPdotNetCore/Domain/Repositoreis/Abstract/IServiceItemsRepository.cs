using ASPdotNetCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPdotNetCore.Domain.Repositoreis.Abstract
{
    interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();

        ServiceItem GetServiceItemById(Guid id);
        
        void SaveServiceItem(ServiceItem entity);

        void DeleteServiceItem(Guid id);
    }
}
