using System;
using System.IO;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();



            //geef nu de stream de volgende waardes:
            //name, waarde: je favoriete streamer
            //lastStreamName, waarde: de streamname van de laatste keer
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            //followers, waarde: hoeveel followers
            //automod, waarde: staat automod aan?
            twitchStream.name = "SpaceBoy";
            twitchStream.lastStreamName = "Gta Rolplay James Randell";
            twitchStream.streamGame = (new Game ( "Gta 5" ));
            twitchStream.followers = 10000000;
            twitchStream.automod = true;


            Console.WriteLine("Hello, World!");
        }
    }
}