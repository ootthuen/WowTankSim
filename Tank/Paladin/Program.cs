using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WOWSharp.Community;
using WOWSharp.Community.Wow;

namespace Paladin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WowClient client = new WowClient(Region.EU);
            Character character = client.GetCharacter("Aszune", "Oot", CharacterFields.Stats);
            CharacterStats characterStats = character.Stats;
            Console.WriteLine("Health: " + characterStats.Health);
            Console.WriteLine("Strength: " + characterStats.Strength);
            Console.WriteLine("Stamina: " + characterStats.Stamina);
            Console.WriteLine("Mastery: " + characterStats.Mastery);
            Console.WriteLine("HasteRating: " + characterStats.HasteRating);
            Console.WriteLine("DodgeChance: " + characterStats.DodgeChance);
            Console.WriteLine("ParryChance: " + characterStats.ParryChance);
            Console.WriteLine("BlockChance: " + characterStats.BlockChance);
            Console.WriteLine("ExpertiseRating: " + characterStats.MainHandExpertise);
            Console.WriteLine("HitRating: " + characterStats.HitRating);

        }
    }
}
