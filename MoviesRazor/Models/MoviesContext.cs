using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MoviesRazor.Models
{
    public class MoviesContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }

        public MoviesContext(DbContextOptions<MoviesContext> options)
           : base(options)
        {
            if (Database.EnsureCreated())
            {

                Movies.AddRange(
                    new Movies { Title = "Neon Genesis Evangelion: The End of Evangelion", Year = 1997, Director = "Hideaki Anno", Genre = "Animation, Drama, Sci-Fi", Img = "~/movies/evagleion1.png", Info = "With the final Angel vanquished, Nerv has one last enemy left to face—the humans under Seele's command. Left in a deep depression nearing the end of the original series, an indecisive Shinji Ikari struggles with the ultimatum presented to him: to completely accept mankind's existence, or renounce humanity's individuality. Meanwhile, at the core of a compromised Nerv, Gendou Ikari and Rei Ayanami approach Lilith in an attempt to realize their own ideals concerning the Instrumentality Project. " },
                    new Movies { Title = "Evangelion: 3.0+1.0 Thrice Upon a Time", Year = 2021, Director = "Hideaki Anno", Genre = "Animation, Drama, Sci-Fi", Img = "~/movies/evangelion4.png", Info = "Shinji Ikari is still adrift after losing his will to live, but the place he arrives at teaches him what it means to hope. Finally, the Instrumentality Project is set in motion and Wille make one last grueling stand to prevent the Final Impact." },
                    new Movies { Title = "Intouchables", Year = 2011, Director = "Olivier Nakache, Éric Toledano", Genre = "Biography, Comedy, Drama", Img = "~/movies/intouchables.png", Info = "A rich quadriplegic, living in a mansion in Paris, requires a live-in carer. A young offender turns up for an interview, but he is not really looking to get the job. However, to his surprise, he is hired. The two men then develop a close friendship." },
                    new Movies { Title = "Persona 3 The Movie: #1 Spring of Birth", Year = 2013, Director = "Noriko Takao", Genre = "Animation, Action, Fantasy", Img = "~/movies/persona.png", Info = "In the spring, male student Makoto Yūki transfers to Gekkoukan High School. However, as he heads to his new dormitory, listening to the music on his headphones, he is stopped. More precisely, time has stopped, and the people who were around him turn into coffins. Makoto learns that this period of time hidden between the minute of midnight is called the Dark Hour, a time when monsters called Shadows appear. Suddenly made the leader of his fellow classmates Yukari and Junpei by his upperclassmen Mitsuru and Akihiko, Makoto must learn empathy, his connection to his comrades, and the meaning of death. With the power of his Evoker aimed at his head, Makoto fights against the Shadows threatening to attack his world from the mysterious tower of Tartarus." },
                    new Movies { Title = "Shrek", Year = 2001, Director = "Andrew Adamson, Vicky Jenson", Genre = "Animation, Adventure, Comedy", Img = "~/movies/shrek.png", Info = "Once upon a time, in a far away swamp, there lived an ogre named Shrek whose precious solitude is suddenly shattered by an invasion of annoying fairy tale characters. They were all banished from their kingdom by the evil Lord Farquaad. Determined to save their home -- not to mention his -- Shrek cuts a deal with Farquaad and sets out to rescue Princess Fiona to be Farquaad's bride. Rescuing the Princess may be small compared to her deep, dark secret." },
                    new Movies { Title = "Shrek 2", Year = 2004, Director = "Andrew Adamson, Kelly Asbury, Conrad Vernon", Genre = "Animation, Adventure, Comedy", Img = "~/movies/sherk2.png", Info = "Shrek, Fiona and Donkey set off to Far, Far Away to meet Fiona's mother and father. But not everyone is happy. Shrek and the King find it hard to get along, and there's tension in the marriage. The fairy godmother discovers that Shrek has married Fiona instead of her Son Prince Charming and sets about destroying their marriage." },
                    new Movies { Title = "Shrek the Third", Year = 2007, Director = "Chris Miller, Raman Hui", Genre = "Animation, Adventure, Comedy", Img = "~/movies/shrek3.png", Info = "When his new father-in-law, King Harold falls ill, Shrek is looked at as the heir to the land of Far, Far Away. Not one to give up his beloved swamp, Shrek recruits his friends Donkey and Puss in Boots to install the rebellious Artie as the new king. Princess Fiona, however, rallies a band of royal girlfriends to fend off a coup d'etat by the jilted Prince Charming." },
                    new Movies { Title = "Shrek Forever After", Year = 2010, Director = "Mike Mitchell", Genre = "Animation, Adventure, Comedy", Img = "~/movies/shrek4.png", Info = "A bored and domesticated Shrek pacts with deal-maker Rumpelstiltskin to get back to feeling like a real ogre again, but when he's duped and sent to a twisted version of Far Far Away -- where Rumpelstiltskin is king, ogres are hunted, and he and Fiona have never met -- he sets out to restore his world and reclaim his true love." },
                    new Movies { Title = "Sonic the Hedgehog", Year = 2020, Director = "Jeff Fowler", Genre = "Action, Adventure, Comedy", Img = "~/movies/sonic.png", Info = "Based on the global blockbuster videogame franchise from Sega, Sonic the Hedgehog tells the story of the world’s speediest hedgehog as he embraces his new home on Earth. In this live-action adventure comedy, Sonic and his new best friend team up to defend the planet from the evil genius Dr. Robotnik and his plans for world domination." },
                    new Movies { Title = "Sonic the Hedgehog 2", Year = 2022, Director = "Jeff Fowler", Genre = "Action, Adventure, Comedy", Img = "~/movies/sonic2.png", Info = "The sequel to the 2020 live-action film Sonic the Hedgehog, based on the video game franchise published by Sega. Plot details are yet to be revealed." }
                );

                SaveChanges();
            }
        }

       
    }
}
