using System;
using System.Collections.Generic;
using System.Text;

namespace Laba.Models
{
    public class StartData
    {
        static public void FillWithData()
        {
            MyItem item = new MyItem();

            item.Title = "Fight club";
            item.Year = 1999;
            item.Country = 3;
            item.Motto = "Intrigues.Chaos.Soap";
            item.Producer = "David Fincher";
            item.Genre = "Drama, Thriller, Criminal";
            item.MainRoles = "Edward Norton, Brad Pitt, Helena Bonham Carter";
            item.ImagePath = "FightClub1";
            item.Description = "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "Forrest Gump";
            item.Year = 1994;
            item.Country = 1;
            item.Motto = "The world will never be the same after you see it through the eyes of Forrest Gump";
            item.Producer = "Robert Zemekis";
            item.Genre = "Drama, Comedy, History";
            item.MainRoles = "Tom Hanks, Robin Rait, Sally Field";
            item.ImagePath = "Forest1";
            item.Description = "The presidencies of Kennedy and Johnson, the events of Vietnam, Watergate, and other history unfold through the perspective of an Alabama man with an IQ of 75.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "God Father";
            item.Year = 1972;
            item.Country = 1;
            item.Motto = "Real power cannot be given, it can be taken...";
            item.Producer = "Francis Ford Coppola";
            item.Genre = "Drama, Criminal";
            item.MainRoles = "Marlon Brando, Al Pacino, James Caan";
            item.ImagePath = "GodFather1";
            item.Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "The Green Mile";
            item.Year = 1999;
            item.Country = 1;
            item.Motto = "Paul Edgecombe did not believe in miracles. Until I ran into one of them";
            item.Producer = "David Fincher";
            item.Genre = "Drama, Fantastic, Detective";
            item.MainRoles = "Tom Hanks, David Mors, Bonny Hunt";
            item.ImagePath = "GreenMile1";
            item.Description = "The lives of guards on Death Row are affected by one of their charges: a black man accused of child murder and rape, yet who has a mysterious gift.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "Inception";
            item.Year = 2010;
            item.Country = 4;
            item.Motto = "Your mind is a place of crime";
            item.Producer = "Kristofer Nolan";
            item.Genre = "Drama, Thriller, Fantasy";
            item.MainRoles = "Leo DiCaprio, Joseph Gordon-Levitt, Tom Hardy";
            item.ImagePath = "Inception1";
            item.Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "Intouchables";
            item.Year = 2011;
            item.Country = 2;
            item.Motto = "Sometimes you have to reach into someone else's world to find out what's missing in your own";
            item.Producer = "Olivie Nakash";
            item.Genre = "Drama, Comedy, Biography";
            item.MainRoles = "Fransua Kluze, Omar Si, Ann Le Ni";
            item.ImagePath = "Untouchables1";
            item.Description = "After he becomes a quadriplegic from a paragliding accident, an aristocrat hires a young man from the projects to be his caregiver.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "Leon";
            item.Year = 1994;
            item.Country = 2;
            item.Motto = "You can't stop someone you can't see";
            item.Producer = "Luc Besson";
            item.Genre = "Drama, Thriller, Criminal";
            item.MainRoles = "Jean Reno, Gary Oldman, Natalie Portman";
            item.ImagePath = "Leon1";
            item.Description = "Mathilda, a 12-year-old girl, is reluctantly taken in by Léon, a professional assassin, after her family is murdered. An unusual relationship forms as she becomes his protégée and learns the assassin's trade.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "Lion King";
            item.Year = 1994;
            item.Country = 1;
            item.Motto = "The circle of life";
            item.Producer = "Roger Allers";
            item.Genre = "Cartoon, Musical, Drama, Adventure";
            item.MainRoles = "Mattew Broderick, Jeremy Irons, Nathan Lane";
            item.ImagePath = "LionKing1";
            item.Description = "A Lion cub crown prince is tricked by a treacherous uncle into thinking he caused his father's death and flees into exile in despair, only to learn in adulthood his identity and his responsibilities.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "The Shawshank Redemption";
            item.Year = 1994;
            item.Country = 1;
            item.Motto = "Fear is shackles. Hope is freedom";
            item.Producer = "Liz Glocer";
            item.Genre = "Drama";
            item.MainRoles = "Tim Robbins, Morgan Friman, Bob Ganton";
            item.ImagePath = "Redemption1";
            item.Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "Schindler's list";
            item.Year = 1993;
            item.Country = 1;
            item.Motto = "This list is life";
            item.Producer = "Stiven Spilberg";
            item.Genre = "Drama, Biography, History";
            item.MainRoles = "Liam Nisson, Ben Kingsly, Carroline Gudoll";
            item.ImagePath = "Schindler1";
            item.Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "Ivan Vasilyevich changes profession";
            item.Year = 1973;
            item.Country = 6;
            item.Motto = "-";
            item.Producer = "Leonid Gaidai";
            item.Genre = "Fantasy, Comedy, Adventure";
            item.MainRoles = "Alexander Demyanenko, Yuri Yakovlev, Leonid Kuravlev";
            item.ImagePath = "Ivan";
            item.Description = "Engineer-inventor Timofeev designed a time machine that connected his apartment with the distant sixteenth century — more precisely, with the chambers of the Emperor Ivan the terrible.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "La vita è bella";
            item.Year = 1997;
            item.Country = 5;
            item.Motto = "An unforgettable fable that proves love, family and imagination conquer all";
            item.Producer = "Roberto Benigni";
            item.Genre = "Melodrama, Comedy, Drama";
            item.MainRoles = "Roberto Benigni, Coletta Braschi, Giorgio Cantarini";
            item.ImagePath = "LifeIsBeautiful";
            item.Description = "During World war II in Italy, Jews, a father and his young son were sent to a concentration camp. His wife, an Italian, voluntarily followed them. At the camp, the father told his son that what was happening around him was a very big game for the prize of a real tank, which would go to the boy who could not catch the eyes of the guards. He made sure that his son believed in the game and remained alive, hiding in the barracks.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "Knockin' on Heaven's Door";
            item.Year = 1997;
            item.Country = 3;
            item.Motto = "A fast car, a million marks in the trunk, and just one week to live";
            item.Producer = "Tomas Jan";
            item.Genre = "Drama, Comedy, Criminal";
            item.MainRoles = "Thiel Schweiger, Jan Josef Liefers, Thierry Van Werveke";
            item.ImagePath = "gSky";
            item.Description = "Fate brings the heroes of the picture in the hospital, where the doctors impose a death sentence on them. The time of their lives is on the clock. Further events in the film unfold at a rapid pace. After stealing a car with a million German marks in the trunk, they escape from the hospital.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "Pulp Fiction";
            item.Year = 1994;
            item.Country = 1;
            item.Motto = "Just because you are a character doesn't mean you have character";
            item.Producer = "Quentin Tarantino";
            item.Genre = "Thriller, Comedy, Criminal";
            item.MainRoles = "John Travolta, Samuel L. Jackson, Bruce Willis, Uma Thurman";
            item.ImagePath = "Pulp";
            item.Description = "Two bandits Vincent Vega and Jules Winfield lead philosophical conversations in between showdowns and solving problems with the debtors of the criminal boss Marcellus Wallace.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "Operation Y and other Shurik's adventures";
            item.Year = 1965;
            item.Country = 6;
            item.Motto = "-";
            item.Producer = "Leonid Gaidai";
            item.Genre = "Comedy, Criminal";
            item.MainRoles = "Alexander Demyanenko, Natalia Selezneva, Alexey Smirnov, Yuri Nikulin";
            item.ImagePath = "YYY";
            item.Description = "The film consists of three short stories, United by the figure of the main character Shurik, who gets into the most incredible situations. In Partner Shurik fights with a bully big Man; in Obsession very original way preparing for the exam; in Operation Y prevents robbery of the century, which is the famous trio - a Balbes, a Trus and a Bywalyi.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "The Prestige";
            item.Year = 2006;
            item.Country = 4;
            item.Motto = "Friendship that became a rivalry. The rivalry that turned into enmity";
            item.Producer = "Kristofer Nolan";
            item.Genre = "Fantasy, Thriller, Drama, Criminal";
            item.MainRoles = "Hugh Jackman, Christian Bale, Michael Caine";
            item.ImagePath = "Prestige";
            item.Description = "Robert and Alfred-magicians-illusionists who at the turn of the XIX and XX centuries competed with each other in London. Over the years, their friendly competition on professional grounds turns into a real war.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "A Beautiful Mind";
            item.Year = 2001;
            item.Country = 1;
            item.Motto = "If reality has ganged up on you, nothing is safe anymore...";
            item.Producer = "Ron Howard";
            item.Genre = "Drama, Biography, Melodrama";
            item.MainRoles = "Russell Crowe, Ed Harris, Jennifer Connelly";
            item.ImagePath = "Mind";
            item.Description = "From the world popularity up to the sinful depths — all learned on the hard way John Forbes Nash, Jr. A mathematical genius, he did Titanic work in the field of game theory at the beginning of his career, which turned this branch of mathematics and almost brought him international fame.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "Interstellar";
            item.Year = 2014;
            item.Country = 4;
            item.Motto = "The next step of humanity will be the greatest";
            item.Producer = "Kristofer Nolan";
            item.Genre = "Fantasy, Drama, Adventure";
            item.MainRoles = "Matthew McConaughey, Anne Hathaway, Jessica Chastain";
            item.ImagePath = "Interstellar";
            item.Description = "When drought, dust storms, and plant extinction drive humanity into a food crisis, a team of researchers and scientists sets out through a wormhole (which supposedly connects regions of space-time across a great distance) on a journey to surpass the previous limitations for human space travel and find a planet with suitable conditions for humanity.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "Gladiator";
            item.Year = 2000;
            item.Country = 4;
            item.Motto = "The General who became a slave. The slave who became a Gladiator. The Gladiator who defied the Empire";
            item.Producer = "Ridley Scott";
            item.Genre = "History, Drama, Adventure";
            item.MainRoles = "Russell Crowe, Joaquin Phoenix, Connie Nielsen";
            item.ImagePath = "Gladiator";
            item.Description = "In the great Roman Empire there was no commander equal to General Maximus. The invincible legions commanded by this noble warrior worshipped him and could follow him even to hell. But it so happened that the brave Maximus, ready to fight any opponent in a fair fight, was powerless against the treacherous court intrigues.The General was betrayed and sentenced to death. Miraculously escaping death, Maximus becomes a Gladiator. Quickly gaining fame in bloody fights, he finds himself in the famous Roman Colosseum, in the arena where he will meet in mortal combat with his sworn enemy…";
            item.IsFavorite = false;
            App.Database.SaveItem(item);

            item = new MyItem();
            item.Title = "The Matrix";
            item.Year = 1999;
            item.Country = 1;
            item.Motto = "Welcome to the real world";
            item.Producer = "Lana Wachowski, Lilly Wachowski";
            item.Genre = "Fantasy, Adventure";
            item.MainRoles = "Keanu Reeves, Lawrence Fishburne, Carrie - Anne Moss";
            item.ImagePath = "Matrix";
            item.Description = "Thomas Anderson's life is divided into two parts: during the day he is the most ordinary office worker, receiving scolding from his superiors, and at night he turns into a hacker named Neo, and there is no place in the network where he could not reach. But one day everything changes — the hero, unwittingly, learns the terrible truth: everything that surrounds him is nothing more than an illusion, a Matrix, and people are just a source of power for the artificial intelligence that enslaved humanity. And only Neo is able to change the balance of forces in this strange and terrible world.";
            item.IsFavorite = false;
            App.Database.SaveItem(item);
        }

       
    }
}
