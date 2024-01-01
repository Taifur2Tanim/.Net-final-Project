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
    public class WishProductService
    {
        public static List<WishProductDTO> Get()
        {
            var data = DataAccessFactory.WishProductData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<WishProduct, WishProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<WishProductDTO>>(data);
            return mapped;
        }

        public static WishProductDTO Get(int id)
        {
            var data = DataAccessFactory.WishProductData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<WishProduct, WishProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<WishProductDTO>(data);
            return mapped;
        }

        public static WishProductDTO Create(WishProductDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<WishProduct, WishProductDTO>();
                c.CreateMap<WishProductDTO, WishProduct>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<WishProduct>(obj);

            var result = DataAccessFactory.WishProductData().Create(data);
            var redata = mapper.Map<WishProductDTO>(result);
            return redata;
        }

        public static WishProductDTO Delete(int id)
        {
            var data = DataAccessFactory.WishProductData().Delete(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<WishProduct, WishProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<WishProductDTO>(data);
            return mapped;
        }

        public static WishProductDTO Update(WishProductDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<WishProduct, WishProductDTO>();
                c.CreateMap<WishProductDTO, WishProduct>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<WishProduct>(obj);

            var result = DataAccessFactory.WishProductData().Update(data);
            var redata = mapper.Map<WishProductDTO>(result);
            return redata;
        }
    }
}

