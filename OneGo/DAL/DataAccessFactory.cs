using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, string, User> UserData()
        {
            return new UserRepo();
        }

        public static IRepo<Hotel, int, Hotel> HotelData()
        {
            return new HotelRepo();
        }

        public static IRepo<WishProduct, int, WishProduct> WishProductData()
        {
            return new WishProductRepo();
        }

        public static IRepo<Event, int, Event> EventData()
        {
            return new EventRepo();
        }

        public static IRepo<UserReview, int, UserReview> UserReviewData()
        {
            return new UserReviewRepo();
        }
    }
}
