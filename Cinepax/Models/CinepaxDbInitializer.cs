using System;

namespace Cinepax.Models
{
    public class CinepaxDbInitializer
    {
        public static void InitData()
        {
            using(CinepaxContext cinepaxContext = new CinepaxContext())
            {
                User user1 = new User
                {
                    FirstName = "Rasolofoniaina",
                    Lastname = "Mickael",
                    Email = "rasolofoniaina_mickael@outlook.fr",
                    Password = "Maodiapasy123!",
                    IsAdmin = false,
                    TotalToken = 50
                };

                User user2 = new User
                {
                    FirstName = "Admin",
                    Lastname = "Cinepax",
                    Email = "admin_cinepax@outlook.fr",
                    Password = "Maodiapasy123!",
                    IsAdmin = true
                };

                cinepaxContext.Users.Add(user1);
                cinepaxContext.Users.Add(user2);

                Movie movie1 = new Movie()
                {
                    Name = "Mission impossible",
                    Description = "Description 1",
                    Picture = "https://cinema.mu/wp-content/uploads/2018/08/Mission-Impossible-fr.jpg",
                    Type = 1
                };

                Movie movie2 = new Movie()
                {
                    Name = "Avengers",
                    Description = "Description 1",
                    Picture = "https://i0.wp.com/www.filmspourenfants.net/wp-content/uploads/2018/01/avengers-a.jpg?fit=555%2C801&ssl=1",
                    Type = 2
                };

                Movie movie3 = new Movie()
                {
                    Name = "Conjuring",
                    Description = "Description 1",
                    Picture = "https://s.s-bol.com/imgbase0/imagebase3/large/FC/5/1/8/9/9200000058729815.jpg",
                    Type = 3
                };

                Movie movie4 = new Movie()
                {
                    Name = "James Bond",
                    Description = "Description 1",
                    Picture = "https://www.cinemaffiche.fr/833-tm_large_default/casino-royale-james-bond-casino-royale.jpg",
                    Type = 1
                };

                Movie movie5 = new Movie()
                {
                    Name = "Die Hard",
                    Description = "Description 1",
                    Picture = "https://media.senscritique.com/media/000006400797/source_big/Die_Hard_Belle_journee_pour_mourir.jpg",
                    Type = 2
                };

                Movie movie6 = new Movie()
                {
                    Name = "Black widow",
                    Description = "Description 1",
                    Picture = "https://www.pinkvilla.com/files/black-widow-final-trailer-of-scarlett-johansson-starrer-to-be-out-this-week-find-out.jpg",
                    Type = 2
                };

                Movie movie7 = new Movie()
                {
                    Name = "Avengers Infinity wars",
                    Description = "Description 1",
                    Picture = "https://images.squarespace-cdn.com/content/v1/58757367b3db2b3e1ec9477d/1525870903326-WTVRQ7Y5UPZFFRB2NVIC/ke17ZwdGBToddI8pDm48kPqVrUPbGraxBXLkTfuv1JJ7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z4YTzHvnKhyp6Da-NYroOW3ZGjoBKy3azqku80C789l0hHMyhIh2kKzuOL3ydJCryCGdMxmSm3gC0_CvVW_M5l8Ta6i4G6tKgaUaFWRDYhGSw/avengers-infinity-war-imax.jpg",
                    Type = 2
                };

                Movie movie8 = new Movie()
                {
                    Name = "Captain Americe civil war",
                    Description = "Description 1",
                    Picture = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6323/6323402_sa.jpg;maxHeight=640;maxWidth=550",
                    Type = 2
                };

                Movie movie9 = new Movie()
                {
                    Name = "Mad Max Fury Road",
                    Description = "Description 1",
                    Picture = "https://fr.web.img3.acsta.net/pictures/15/04/14/18/30/215297.jpg",
                    Type = 2
                };

                cinepaxContext.Movies.Add(movie1);
                cinepaxContext.Movies.Add(movie2);
                cinepaxContext.Movies.Add(movie3);
                cinepaxContext.Movies.Add(movie4);
                cinepaxContext.Movies.Add(movie5);


                Room room = new Room()
                {
                    Name = "Salle A"
                };

                Room roomB = new Room()
                {
                    Name = "Salle B"
                };

                cinepaxContext.Rooms.Add(room);

                Projection projection1 = new Projection()
                {
                    ProjectionDate = new DateTime(2020, 4, 13),
                    Room = room,
                    Movie = movie1,
                    Price = 10
                };

                Projection projection2 = new Projection()
                {
                    ProjectionDate = new DateTime(2020, 4, 14),
                    Room = room,
                    Movie = movie2,
                    Price = 20
                };

                Projection projection3 = new Projection()
                {
                    ProjectionDate = new DateTime(2020, 4, 15),
                    Room = room,
                    Movie = movie3,
                    Price = 15
                };

                Projection projection4 = new Projection()
                {
                    ProjectionDate = new DateTime(2020, 4, 16),
                    Room = room,
                    Movie = movie4,
                    Price = 25
                };

                Projection projection5 = new Projection()
                {
                    ProjectionDate = new DateTime(2020, 4, 17),
                    Room = room,
                    Movie = movie5,
                    Price = 5
                };

                Projection projection6 = new Projection()
                {
                    ProjectionDate = new DateTime(2020, 4, 18),
                    Room = roomB,
                    Movie = movie6,
                    Price = 9
                };

                Projection projection7 = new Projection()
                {
                    ProjectionDate = new DateTime(2020, 4, 19),
                    Room = roomB,
                    Movie = movie7,
                    Price = 11
                };

                Projection projection8 = new Projection()
                {
                    ProjectionDate = new DateTime(2020, 4, 20),
                    Room = roomB,
                    Movie = movie8,
                    Price = 12
                };

                Projection projection9 = new Projection()
                {
                    ProjectionDate = new DateTime(2020, 4, 21),
                    Room = room,
                    Movie = movie9,
                    Price = 18
                };

                cinepaxContext.Projections.Add(projection1);
                cinepaxContext.Projections.Add(projection2);
                cinepaxContext.Projections.Add(projection3);
                cinepaxContext.Projections.Add(projection4);
                cinepaxContext.Projections.Add(projection5);
                cinepaxContext.Projections.Add(projection6);
                cinepaxContext.Projections.Add(projection7);
                cinepaxContext.Projections.Add(projection8);
                cinepaxContext.Projections.Add(projection9);

                cinepaxContext.SaveChanges();
            }
            
        }

    }
}
