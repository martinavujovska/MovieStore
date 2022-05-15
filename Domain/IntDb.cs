using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using Domain.Classes;

namespace Domain
{
    public static class IntDb
    {
        public static void ShowMovies()
        {
            foreach (var movie in IntDb.Movies)
            {
                movie.DisplayMovieInfo();
            }
        }
        public static string GetUsername()
        {
            Console.WriteLine("Enter your username and password");
            Console.WriteLine("Username:");
            string usernameInput = Console.ReadLine();
            return usernameInput;
        }
        public static string GetPassword()
        {
            Console.WriteLine("Password");
            string passwordInput = Console.ReadLine();
            return passwordInput;
        }

        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee("Martina", "Vujovska", Enums.Role.Employee, "0000"),
            new Employee("Bojan", "Trpcevski", Enums.Role.Employee, "1111")
        };

        public static List<User> Users = new List<User>()
        {
            new User("Mark", "McKenna", "000000", Enums.Role.User, Enums.SubscriptionType.Annually, "13/01/22"),
            new User("Cillian", "Murphy", "000000", Enums.Role.User, Enums.SubscriptionType.Monthly, "28/02/22"),
            new User("Billy", "Idol", "000000", Enums.Role.User, Enums.SubscriptionType.Monthly, "14/03/22"),
            new User("Sheldon", "Cooper", "000000", Enums.Role.User, Enums.SubscriptionType.Annually, "15/03/22"),
            new User("Monica", "Geller", "000000", Enums.Role.User, Enums.SubscriptionType.Annually, "29/03/22"),
            new User("Johnny", "Bravo", "000000", Enums.Role.User, Enums.SubscriptionType.Monthly, "08/03/22")
        };

        public static List<Movie> Movies = new List<Movie>()
            {
            new Movie()
            {
                Title = "American History X",
                Year = 1998,
                Description = "Derek, who has served three years in prison for a hate crime, tries to change the thoughts of his brother, Danny, who is following the same path.",
                Genre = Enums.Genre.Drama,
                IsRented = false,
                InStoreId = 1
            },
            new Movie()
            {
                Title = "Split",
                Year = 2016,
                Description = "Kevin, who is suffering from dissociative identity disorder and has 23 alter egos, kidnaps three teenagers. " +
                "They must figure out his friendly personas before he unleashes his 24th personality.",
                Genre = Enums.Genre.Horror,
                IsRented = true,
                InStoreId = 2
    },
            new Movie()
            {
                Title = "The Game",
                Year = 1997,
                Description = "Nicholas Van Orton, a merchant banker, receives a strange birthday gift, a voucher for a game, from his brother Conrad. " +
                "When he actually makes use of the present, he finds himself in trouble.",
                Genre = Enums.Genre.Thriller,
                IsRented = false,
                InStoreId = 3
    },
            new Movie()
            {
                Title = "Vertigo",
                Year = 1958,
                Description = "Detective Scottie who suffers from acrophobia is hired to investigate the strange activities of an old friend's wife. ",
                Genre = Enums.Genre.Thriller,
                IsRented = false,
                InStoreId = 4
    },
            new Movie()
            {
                Title = "Detroit Rock City",
                Year = 1999,
                Description = "Rock loving teens and aspiring musicians Hawk, Lex, Trip and Jam can't wait to see their favorite band, KISS, perform at an upcoming concert. " +
                "However, when Jam's mom finds the tickets to the event, she burns them, leaving the boys desperate for a way to see KISS, the lads endure misunderstandings," +
                " humiliation and violence, all to see their beloved idols.",
                Genre = Enums.Genre.Comedy,
                IsRented = true,
                InStoreId = 5
    },
            new Movie()
            {
                Title = "Friday",
                Year = 1996,
                Description = "Craig and Smokey spend their time wishing their day was more eventful. Their dreams come true when encounters with their neighbours add spice to their life.",
                Genre = Enums.Genre.Comedy,
                IsRented = false,
                InStoreId = 6
    },
            new Movie()
            {
                Title = "Get Out",
                Year = 2017,
                Description = "Chris, an African-American man, decides to visit his Caucasian girlfriend's parents during a weekend getaway. " +
                "Although they seem normal at first, he is not prepared to experience the horrors ahead.",
                Genre = Enums.Genre.Horror,
                IsRented = false,
                InStoreId = 7
    },
            new Movie()
            {
                Title = "The First Time",
                Year = 2012,
                Description = "A spark of attraction smolders, then ignites, between two teens (Dylan O'Brien, Britt Robertson) from different high schools who meet by chance at a party.",
                Genre = Enums.Genre.Romance,
                IsRented = true,
                InStoreId = 8
    },
            new Movie()
            {
                Title = "Eternal Sunshine Of The Spotless Mind",
                Year = 2004,
                Description = "Joel and Clementine begin a relationship after a train journey together. However, having had their memories clinically erased, they do not remember " +
                "their tumultuous past.",
                Genre = Enums.Genre.Drama,
                IsRented = false,
                InStoreId = 9
    },
            new Movie()
            {
                Title = "The Number 23",
                Year = 2007,
                Description = "Walter becomes obsessed with the details of a book titled 'The Number 23'. He soon starts connecting events in his life to the chapters in the book.",
                Genre = Enums.Genre.Horror,
                IsRented = true,
              InStoreId = 10
    },
            new Movie()
            {
                Title = "Before I Go To Sleep",
                Year = 2014,
                Description = "Christine Lucas grapples with her memory loss and tries to recall her past. Things take an unexpected turn when she discovers horrifying truths about her life.",
                Genre = Enums.Genre.Thriller,
                IsRented = false,
                InStoreId= 11
    },
            new Movie()
    {
        Title = "The Truman Show",
                Year = 1998,
                Description = "An insurance salesman is oblivious of the fact that his entire life is a TV show and his family members are mere actors. " +
                "As he starts noticing things and uncovers the truth, he decides to escape.",
                Genre = Enums.Genre.SciFi,
                 IsRented = false,
                InStoreId = 12
    },
            new Movie()
    {
        Title = "Room",
                Year = 2015,
                Description = "After years of being held captive in an isolated shed by a kidnapper, Joy and her little son, Jack, manage to escape the confinement and gain their freedom.",
                Genre = Enums.Genre.Drama,
                IsRented = true,
                InStoreId = 13
    },
            new Movie()
    {
        Title = "In Time",
                Year = 2011,
                Description = "In a future where people stop ageing after 25 and need to buy time to live, the rich become immortal while others cease to exist. " +
                "So, Will is on the run with a hostage in a desperate bid to survive.",
                Genre = Enums.Genre.SciFi,
                IsRented = false,
                InStoreId = 14
             }
        };
    }
}