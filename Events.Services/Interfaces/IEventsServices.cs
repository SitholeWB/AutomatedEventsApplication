﻿using Events.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Events.Services.Interfaces
{
    public interface IEventsServices
    {

        Task<IEnumerable<Event>> GetAllEventsAsync();
        Task<Event> GetEventByIDAsync(int id);
        Task<int> CreateEventAsync(Event newEvent);
        Task UpdateEventAsync(Event updatedEvent);
        Task DeleteEventAsync(int id);
    }
}
