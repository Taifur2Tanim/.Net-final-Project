using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class EventService
    {
        public static List<EventDTO> Get()
        {
            var data = DataAccessFactory.EventData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Event, EventDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<EventDTO>>(data);
            return mapped;
        }

        public static EventDTO Get(int id)
        {
            var data = DataAccessFactory.EventData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Event, EventDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<EventDTO>(data);
            return mapped;
        }

        public static EventDTO Create(EventDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Event, EventDTO>();
                c.CreateMap<EventDTO, Event>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Event>(obj);

            var result = DataAccessFactory.EventData().Create(data);
            var redata = mapper.Map<EventDTO>(result);
            return redata;
        }

        public static EventDTO Delete(int id)
        {
            var data = DataAccessFactory.EventData().Delete(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Event, EventDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<EventDTO>(data);
            return mapped;
        }

        public static EventDTO Update(EventDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Event, EventDTO>();
                c.CreateMap<EventDTO, Event>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Event>(obj);

            var result = DataAccessFactory.EventData().Update(data);
            var redata = mapper.Map<EventDTO>(result);
            return redata;
        }
    }
}
