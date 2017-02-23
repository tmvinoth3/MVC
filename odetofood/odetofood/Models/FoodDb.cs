using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace odetofood.Models
{
    public class FoodDb 
    {
        static List<RestaurantReview> _reviews;
        // _reviews = new List<RestaurantReview>();
        static FoodDb()
        {
           _reviews = new List<RestaurantReview>();
           _reviews.Add(new RestaurantReview
           {
            //   id = 1,
               Name = "HotChips",
               Rating = 4
           }
           );
           _reviews.Add(new RestaurantReview
           {
            //   id = 2,
               Name = "Noorus",
               Rating = 3
           }
           );
           _reviews.Add(new RestaurantReview
           {
              // id = 3,
               Name = "Pnsmy",
               Rating = 4
           }
           );
        }
        public void createReview(string name,int rating)
        {
            _reviews.Add(new RestaurantReview
            {
                //id = _reviews.Count()+1,
                Name = name,
                Rating = rating
            }
            );
        }
//        public void editReview(string name, int rating)
//        {
//           / _reviews.RemoveAt(id);
//            _reviews.Insert(id,new RestaurantReview
//            {
//                id=id,
//                Name = name,
//                Rating = rating
//            }
//);
//        }
        public List<RestaurantReview> findLatest(int count)
        {
            List<RestaurantReview> l = new List<RestaurantReview>();
            foreach (var item in _reviews)
            {
                l.Add(item);
            }
            return l;
        }
        }


    }


