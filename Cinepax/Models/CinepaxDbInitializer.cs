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
                    TotalToken = 10
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
                    Picture = "https://cinema.mu/wp-content/uploads/2018/08/Mission-Impossible-fr.jpg",
                    Type = 2
                };

                Movie movie3 = new Movie()
                {
                    Name = "Conjuring",
                    Description = "Description 1",
                    Picture = "https://cinema.mu/wp-content/uploads/2018/08/Mission-Impossible-fr.jpg",
                    Type = 3
                };

                Movie movie4 = new Movie()
                {
                    Name = "James Bond",
                    Description = "Description 1",
                    Picture = "https://cinema.mu/wp-content/uploads/2018/08/Mission-Impossible-fr.jpg",
                    Type = 1
                };

                Movie movie5 = new Movie()
                {
                    Name = "Die Hard",
                    Description = "Description 1",
                    Picture = "https://cinema.mu/wp-content/uploads/2018/08/Mission-Impossible-fr.jpg",
                    Type = 2
                };

                Movie movie6 = new Movie()
                {
                    Name = "Black widow",
                    Description = "Description 1",
                    Picture = "https://cinema.mu/wp-content/uploads/2018/08/Mission-Impossible-fr.jpg",
                    Type = 2
                };

                Movie movie7 = new Movie()
                {
                    Name = "Avengers Infinity wars",
                    Description = "Description 1",
                    Picture = "https://cinema.mu/wp-content/uploads/2018/08/Mission-Impossible-fr.jpg",
                    Type = 2
                };

                Movie movie8 = new Movie()
                {
                    Name = "Captain Americe civil war",
                    Description = "Description 1",
                    Picture = "https://cinema.mu/wp-content/uploads/2018/08/Mission-Impossible-fr.jpg",
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
                    ProjectionDate = DateTime.Now,
                    Room = room,
                    Movie = movie1,
                    Price = 10
                };

                Projection projection2 = new Projection()
                {
                    ProjectionDate = DateTime.Now,
                    Room = room,
                    Movie = movie2,
                    Price = 20
                };

                Projection projection3 = new Projection()
                {
                    ProjectionDate = DateTime.Now,
                    Room = room,
                    Movie = movie3,
                    Price = 15
                };

                Projection projection4 = new Projection()
                {
                    ProjectionDate = DateTime.Now,
                    Room = room,
                    Movie = movie4,
                    Price = 25
                };

                Projection projection5 = new Projection()
                {
                    ProjectionDate = DateTime.Now,
                    Room = room,
                    Movie = movie5,
                    Price = 5
                };

                Projection projection6 = new Projection()
                {
                    ProjectionDate = DateTime.Now,
                    Room = roomB,
                    Movie = movie6,
                    Price = 9
                };

                Projection projection7 = new Projection()
                {
                    ProjectionDate = DateTime.Now,
                    Room = roomB,
                    Movie = movie7,
                    Price = 11
                };

                Projection projection8 = new Projection()
                {
                    ProjectionDate = DateTime.Now,
                    Room = roomB,
                    Movie = movie8,
                    Price = 12
                };

                cinepaxContext.Projections.Add(projection1);
                cinepaxContext.Projections.Add(projection2);
                cinepaxContext.Projections.Add(projection3);
                cinepaxContext.Projections.Add(projection4);
                cinepaxContext.Projections.Add(projection5);
                cinepaxContext.Projections.Add(projection6);
                cinepaxContext.Projections.Add(projection7);
                cinepaxContext.Projections.Add(projection8);

                cinepaxContext.SaveChanges();
            }
            
        }

    }
}
