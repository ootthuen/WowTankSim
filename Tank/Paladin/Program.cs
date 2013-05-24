using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paladin
{
    public class Program
    {
        public static readonly Random Random = new Random();

        private static readonly Boss Boss = new Boss
                                                {
                                                    DamagePerHit = 350000, 
                                                    SwingTimer = 2
                                                };

        private static readonly Tank TankHaste = new Tank
                                                     {
                                                         CurrentHP = 670068,
                                                         MaxHP = 670068,
                                                         Parry = 13.47f,
                                                         Dodge = 2.64f,
                                                         Block = 21.72f,
                                                         AttackPower = 26935,
                                                         Armor = 55321,
                                                         Haste = 9.66f,
                                                         ChanceToHit = 1f,
                                                     };

        private static readonly Tank TankAvoidance = new Tank
                                                         {
                                                             CurrentHP = 683388,
                                                             MaxHP = 683388,
                                                             Parry = 18.71f,
                                                             Dodge = 6.53f,
                                                             Block = 24.11f,
                                                             AttackPower = 26935,
                                                             Armor = 57017,
                                                             Haste = 0.77f,
                                                             ChanceToHit = 90.1f,
                                                         };

        public static void Main(string[] args)
        {
            Simulate(TankHaste, "TankHaste", numberOfBossSwings: 7, numberOfSimulations: 100000);
            Simulate(TankAvoidance, "TankAvoidance", numberOfBossSwings: 7, numberOfSimulations: 100000);
            Console.ReadKey();
        }

        private static void Simulate(Tank tank, string tankType, int numberOfBossSwings, int numberOfSimulations)
        {
            int deaths = 0;
            for (int i = 0; i < numberOfSimulations; i++)
            {
                bool doesTankDieAfter = DoesTankDieAfter(numberOfBossSwings, tank);
                if (doesTankDieAfter)
                {
                    deaths++;
                }
            }
            float deathRate = (float)deaths / numberOfSimulations * 100;
            Console.WriteLine(string.Format("{2}:\tIf boss chains {1} hits, tank dies {0}% of the time", deathRate, numberOfBossSwings, tankType));
        }

        private static bool DoesTankDieAfter(int numberOfBossSwings, Tank tank)
        {
            float timeSinceSacredShieldProc = 6;
            tank.CurrentHP = tank.MaxHP;
            for (int i = 0; i < numberOfBossSwings; i++)
            {
                tank.Heal(tank.SealHealPerSec() * Boss.SwingTimer);
                timeSinceSacredShieldProc += Boss.SwingTimer;
                int avoidanceRoll = Random.Next(100);
                if (avoidanceRoll >= tank.Avoidance)
                {
                    float damage = Boss.DamagePerHit;
                    damage = damage * tank.ArmorDamageReduction();
                    damage = damage * tank.ShieldOfTheRightousFactor();
                    int blockRoll = Random.Next(100);
                    if (blockRoll >= tank.Block)
                    {
                        damage = damage * 0.7f;
                    }
                    if (timeSinceSacredShieldProc >= 6)
                    {
                        timeSinceSacredShieldProc = 0;
                        damage = damage - (343 + 1.17f * tank.SpellPower);
                    }
                    tank.CurrentHP -= (int)damage;
                    if (tank.CurrentHP <= 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //shield absorbs up to (343 + 1.17 * holy spell power) damage every 6 sec.
        //: Target Armor / (Target Armor + 46257.5)
    }

    public class Tank
    {
        public int SpellPower
        {
            get { return this.AttackPower / 2; }
        }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public float Parry { get; set; }
        public float Block { get; set; }
        public float Dodge { get; set; }

        public float Avoidance
        {
            get { return this.Dodge + this.Parry; }
        }

        public int Armor { get; set; }

        public int AttackPower { get; set; }

        public float Haste { get; set; }

        public float ChanceToHit { get; set; }

        public float ArmorDamageReduction()
        {
            return this.Armor / (this.Armor + 46257.5f);
        }

        //(0.15 * Attack power.15 * holy spell power)
        public float SealHealPerSec()
        {
            float attacksPerSecond = 1 / 2.6f / GetHasteFactor();
            float spellsPerSecond = 1 / (3 + 5.4f) / GetGcd();
            const float sealProcRate = 0.867f;
            float numberOfSealHealsPerSec = (attacksPerSecond + spellsPerSecond) * sealProcRate * this.ChanceToHit;
            return numberOfSealHealsPerSec * 0.15f * (this.AttackPower + this.SpellPower);
        }

        private float GetGcd()
        {
            return 1.5f * GetHasteFactor();
        }

        private float GetHasteFactor()
        {
            return 1 - this.Haste / (100 + this.Haste);
        }

        public float ShieldOfTheRightousFactor()
        {
            float f = 3f / (5.4f * this.GetGcd()) * (0.25f + this.Block * 0.01f);
            return 1 - f;
        }

        public void Heal(float hitPoints)
        {
            this.CurrentHP += (int)hitPoints;
            if (this.CurrentHP > this.MaxHP)
            {
                this.CurrentHP = this.MaxHP;
            }
        }
    }

    public class Boss
    {
        public float SwingTimer { get; set; }
        public int DamagePerHit { get; set; }
    }
}
