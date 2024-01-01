using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HotelService
    {
        public static List<HotelDTO> Get()
        {
            var data = DataAccessFactory.HotelData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Hotel, HotelDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<HotelDTO>>(data);
            return mapped;
        }

        public static HotelDTO Get(int id)
        {
            var data = DataAccessFactory.HotelData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Hotel, HotelDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<HotelDTO>(data);
            return mapped;
        }

        public static HotelDTO Create(HotelDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Hotel, HotelDTO>();
                c.CreateMap<HotelDTO, Hotel>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Hotel>(obj);

            var result = DataAccessFactory.HotelData().Create(data);
            var redata = mapper.Map<HotelDTO>(result);
            return redata;
        }

        public static HotelDTO Delete(int id)
        {
            var data = DataAccessFactory.HotelData().Delete(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Hotel, HotelDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<HotelDTO>(data);
            return mapped;
        }

        public static HotelDTO Update(HotelDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Hotel, HotelDTO>();
                c.CreateMap<HotelDTO, Hotel>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Hotel>(obj);

            var result = DataAccessFactory.HotelData().Update(data);
            var redata = mapper.Map<HotelDTO>(result);
            return redata;
        }
    }
}

