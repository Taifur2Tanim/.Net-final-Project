using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class UserReviewService
    {
        public static List<UserReviewDTO> Get()
        {
            var data = DataAccessFactory.UserReviewData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserReview, UserReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<UserReviewDTO>>(data);
            return mapped;
        }

        public static UserReviewDTO Get(int id)
        {
            var data = DataAccessFactory.UserReviewData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserReview, UserReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserReviewDTO>(data);
            return mapped;
        }

        public static UserReviewDTO Create(UserReviewDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserReview, UserReviewDTO>();
                c.CreateMap<UserReviewDTO, UserReview>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<UserReview>(obj);

            var result = DataAccessFactory.UserReviewData().Create(data);
            var redata = mapper.Map<UserReviewDTO>(result);
            return redata;
        }

        public static UserReviewDTO Delete(int id)
        {
            var data = DataAccessFactory.UserReviewData().Delete(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserReview, UserReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserReviewDTO>(data);
            return mapped;
        }

        public static UserReviewDTO Update(UserReviewDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserReview, UserReviewDTO>();
                c.CreateMap<UserReviewDTO, UserReview>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<UserReview>(obj);

            var result = DataAccessFactory.UserReviewData().Update(data);
            var redata = mapper.Map<UserReviewDTO>(result);
            return redata;
        }
    }
}

