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
                Name = "Alex Miren",
                AdditionalInfo = @"Elon Reeve Musk (/ˈiːlɒn ˈmʌsk/; born June 28, 1971) is a South African-born Canadian-American business magnate, investor,[11][12] engineer,[13] and inventor.[14][15][16][17]He is the founder,
                CEO,and CTO of SpaceX; co - founder, CEO, and product architect of Tesla Motors; co - founder and chairman of SolarCity; co - chairman of OpenAI; co - founder of Zip2; and founder of X.com which merged with PayPal of Confinity.[18][19][20][21] As of June 2016, he has an estimated net worth of US$11.5 billion, making him the 83rd wealthiest person in the world.[2",
                ApplicationUserId = "StubId1",
                Birthday = DateTime.Now,
                Phone = "0-111-000",
                IsPhoneVisible = true,
                Photo = "man1.jpg"
            };
            var user2 = new UserInfo
            {
                Name = "Johan Step",
                AdditionalInfo = "Frank, father of three, arrives at the Sunshine Home For Blind Children and makes a new friend – two-year old Bonita. “I have always had this same deep feeling about children. But it is the first time I have had the chance to get out and do something.” - Frank Sinatra ",
                ApplicationUserId = "StubId2",
                Birthday = DateTime.Now,
                Phone = "0-222-000",
                IsPhoneVisible = true,
                Photo = "man2.jpg"
            };
            var user3 = new UserInfo
            {
                Name = "Dean Marriles",
                AdditionalInfo = "Lyn Morris My mum adored him from when he first started out, ,,, she used to sing his songs in pubs and clubs, --we were fed up of hearing his songs, ,,, now I'm older I have turned into my mum, :: I think he was a good man ,,, and a great singer ,",
                ApplicationUserId = "StubId3",
                Birthday = DateTime.Now,
                Phone = "0-333-000",
                IsPhoneVisible = true,
                Photo = "man3.jpg"
            };

            db.Users.AddRange(new List<UserInfo> {user1, user2, user3});
            db.SaveChanges();

            var dog1 = new Dog
            {
                Name = "Didi",
                AdditionalInfo = @"he German Shepherd Dog is one of America’s most popular dog breeds — for good reason. He’s an intelligent and capable working dog. His devotion and courage are unmatched. And he’s amazingly versatile, excelling at most anything he’s trained to do: guide and assistance work for the handicapped, police and military service, herding, search and rescue, drug detection, competitive obedience and, last but not least, faithful companion.",
                Breed = "Barbet",
                Photo = "dog2.jpg",
                User = user1
            };

            var dog2 = new Dog
            {
                Name = "Richard",
                AdditionalInfo = "The Japanese Chin dog breed hails from Asia, where he has been prized as a companion for more than a thousand years. He was a popular member of Chinese and Japanese imperial courts, and it was in Japan that his distinctive look was developed. This breed is elegant and dainty, mild-mannered and playful.",
                Breed = "Cane Corso",
                Photo = "dog1.jpg",
                User = user2
            };

            var dog3 = new Dog
            {
                Name = "Ommy",
                AdditionalInfo = "A mixed-breed dog is a testament to nature. Without any input — some might say interference — from humans, the mixed breed defies description. Available in all sizes, shapes, colors, and patterns, he might have a long snout or a short nose. He may display prick ears or floppy ones. He could have a stubby tail, spindly legs, a giant spot over his left eye — or all three. A divine inspiration, the mixed breed is gloriously, wonderfully someone else’s design.",
                Breed = "Goldador",
                Photo = "dog3.jpg",
                User = user3
            };

            db.Dogs.AddRange(new List<Dog> { dog1, dog2, dog3 });
            db.SaveChanges();

            var request1 = new Request
            {
                Address = "Kolomenskaya, 28",
                Dog = dog1,
                Text = "The Shiba Inu dog breed was originally bred to flush birds and small game, and was occasionally used to hunt wild boar. He is one of Japan’s six native breeds: Akita (large), Kishu, Hokkaido, Kai, Shikoku (medium), and Shiba (small). He is known for his spirited personality, small upright ears, and cat-like agility. Today he serves primarily as a companion dog in Japan and the United States.",
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
                Address = "Kolomenskaya, 13",
                Dog = dog2,
                Text = "Out of Africa, the Basenji dog breed was originally found in the Congo. He uses both scent and sight to hunt and was originally used to flush small game into a hunter’s nets and to control village rodent populations. Clever and endearing, he’s a good companion for the person or family who can stay a step ahead of him.",
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
