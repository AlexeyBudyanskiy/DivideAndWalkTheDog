using System;
using System.Collections.Generic;
using System.Data.Entity;
using DivideAndWalkTheDog.DAL.Entities;

namespace DivideAndWalkTheDog.DAL.EF
{
    public class DbInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {
            var user1 = new UserInfo
            {
                Name = "Alex Mirnyi",
                AdditionalInfo = @"Elon Reeve Musk (/ˈiːlɒn ˈmʌsk/; born June 28, 1971) is a South African-born Canadian-American business magnate, investor,[11][12] engineer,[13] and inventor.[14][15][16][17]He is the founder,
                CEO,and CTO of SpaceX; co - founder, CEO, and product architect of Tesla Motors; co - founder and chairman of SolarCity; co - chairman of OpenAI; co - founder of Zip2; and founder of X.com which merged with PayPal of Confinity.[18][19][20][21] As of June 2016, he has an estimated net worth of US$11.5 billion, making him the 83rd wealthiest person in the world.[2",
                ApplicationUserId = "StubId1",
                Birthday = DateTime.Now,
                Phone = "0-000-000",
                IsPhoneVisible = true,
                Photo = "man1.jpg"
            };
            var user2 = new UserInfo
            {
                Name = "UserName2",
                AdditionalInfo = "AddititionalInfo2",
                ApplicationUserId = "StubId2",
                Birthday = DateTime.Now,
                Phone = "0-000-000",
                IsPhoneVisible = true,
                Photo = "man2.jpg"
            };
            var user3 = new UserInfo
            {
                Name = "UserName3",
                AdditionalInfo = "AddititionalInfo3",
                ApplicationUserId = "StubId3",
                Birthday = DateTime.Now,
                Phone = "0-000-000",
                IsPhoneVisible = true,
                Photo = "man3.jpg"
            };

            db.Users.AddRange(new List<UserInfo> {user1, user2, user3});
            db.SaveChanges();

            var dog1 = new Dog
            {
                Name = "DogName1",
                AdditionalInfo = "AddititionalInfo1",
                Breed = "Spoker",
                Photo = "dog2.jpg",
                User = user1
            };

            var dog2 = new Dog
            {
                Name = "DogName2",
                AdditionalInfo = "AddititionalInfo2",
                Breed = "Spaniel",
                Photo = "dog1.jpg",
                User = user2
            };

            var dog3 = new Dog
            {
                Name = "DogName2",
                AdditionalInfo = "AddititionalInfo2",
                Breed = "Dogger",
                Photo = "dog3.jpg",
                User = user3
            };

            db.Dogs.AddRange(new List<Dog> { dog1, dog2, dog3 });
            db.SaveChanges();

            var request1 = new Request
            {
                Address = "AddressString",
                Dog = dog1,
                Text = "Some stub text",
                TimePeriodsWhenUserCanWalk = new List<TimePeriod>
                {
                    new TimePeriod
                    {
                        Day = 1,DayTimeFinish = 7, DayTimeStart = 6
                    },
                    new TimePeriod
                    {
                        Day = 3,DayTimeFinish = 18, DayTimeStart = 17
                    }
                },
                TimePeriodsWhenUserNeedWalk = new List<TimePeriod>
                {
                   new TimePeriod
                    {
                        Day = 1,DayTimeFinish = 7, DayTimeStart = 6
                    },
                    new TimePeriod
                    {
                        Day = 3,DayTimeFinish = 18, DayTimeStart = 17
                    }
                },
                User = user1
            };

            var request2 = new Request
            {
                Address = "AddressString2",
                Dog = dog2,
                Text = "Some stub text 2222222222222",
                TimePeriodsWhenUserCanWalk = new List<TimePeriod>
                {
                    new TimePeriod
                    {
                        Day = 1,DayTimeFinish = 7, DayTimeStart = 6
                    },
                    new TimePeriod
                    {
                        Day = 3,DayTimeFinish = 18, DayTimeStart = 17
                    }
                },
                TimePeriodsWhenUserNeedWalk = new List<TimePeriod>
                {
                    new TimePeriod
                    {
                        Day = 1,DayTimeFinish = 7, DayTimeStart = 6
                    },
                    new TimePeriod
                    {
                        Day = 3,DayTimeFinish = 18, DayTimeStart = 17
                    }
                },
                User = user2
            };

            db.Requests.AddRange(new List<Request> { request1, request2});
            db.SaveChanges();

            var message1 = new Message
            {
                DateTime = DateTime.Now,
                Reciever = user1,
                Sender = user2,
                Text = "Message 1"
            };

            var message2 = new Message
            {
                DateTime = DateTime.Now,
                Reciever = user2,
                Sender = user1,
                Text = "Message 2"
            };

            var message3 = new Message
            {
                DateTime = DateTime.Now,
                Reciever = user2,
                Sender = user1,
                Text = "Message 3"
            };

            var message4 = new Message
            {
                DateTime = DateTime.Now,
                Reciever = user1,
                Sender = user2,
                Text = "Message 4"
            };

            var message5 = new Message
            {
                DateTime = DateTime.Now,
                Reciever = user3,
                Sender = user2,
                Text = "Another"
            };

            var message6 = new Message
            {
                DateTime = DateTime.Now,
                Reciever = user3,
                Sender = user1,
                Text = "Another messs2"
            };

            db.Messages.AddRange(new List<Message> { message1,message2,message3,message4,message5,message6});
            db.SaveChanges();

        }       
    }
}
