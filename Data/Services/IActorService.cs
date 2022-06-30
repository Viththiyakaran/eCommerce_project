using eCommerce_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_project.Data.Services
{
     public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAll();

        Actor GetById(int id);

        void Add(Actor actor);

        Actor Update(int id, Actor newActor);

        void Delete(int id);

    }
}
