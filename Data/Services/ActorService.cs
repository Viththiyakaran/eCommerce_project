using eCommerce_project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_project.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly AppDbContext _context;

        public ActorService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var data = await _context.Actors.ToListAsync();
            return (data);
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }

      
    }
}
