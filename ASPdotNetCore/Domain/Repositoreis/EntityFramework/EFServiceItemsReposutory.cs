using ASPdotNetCore.Domain.Entities;
using ASPdotNetCore.Domain.Repositoreis.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPdotNetCore.Domain.Repositoreis.EntityFramework
{
    public class EFServiceItemsReposutory : IServiceItemsRepository
    {
        private readonly AppDbContext context;

        public EFServiceItemsReposutory(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItems;
        }

        public ServiceItem GetServiceItemById(Guid id)
        {
            return context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }


        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;

            }
            else
                context.Entry(entity).State = EntityState.Modified;
        }

        public void DeleteServiceItem(Guid id)
        {
            context.TextFields.Remove(new TextField() { Id = id });
            context.SaveChanges();
        }
    }
}
