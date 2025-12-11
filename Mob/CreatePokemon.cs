using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mob
{
    internal static class CreatePokemon
    {
        public static void MakeAllPokemon()
        {
            Pokemon pok1 = new Pokemon(
                "Divine Intellect",
                1000,
                99,
                10000000,
                "None",
                "",
                "Rapture"
            ); // original
            Pokemon pok2 = new Pokemon("FiHGOD", 500, 95, 1200, "None", "", "Afisholypse");
            Pokemon pok3 = new Pokemon("Richard", 450, 90, 1100, "None", "", "Doom");
            Pokemon pok4 = new Pokemon("FiHGON", 420, 88, 1050, "None", "", "Fish cage");
            Pokemon pok5 = new Pokemon("Richier", 400, 85, 1000, "None", "", "Flash");
            Pokemon pok6 = new Pokemon("FiH Magikarp", 380, 82, 950, "None", "", "FIH");
            Pokemon pok7 = new Pokemon("Richi", 360, 80, 900, "None", "", "FESCHT HÄBE");

            Pokemon pok8 = new Pokemon("Rayquaza Max", 350, 78, 850, "None", "", "Chained Storms");
            Pokemon pok9 = new Pokemon(
                "N's Reshiram",
                340,
                76,
                830,
                "None",
                "",
                "Concentrated Meteor"
            );
            Pokemon pok10 = new Pokemon("Umbreon", 260, 85, 820, "None", "", "Luminar Buff");
            Pokemon pok11 = new Pokemon("Lucario", 320, 65, 780, "None", "", "Pierced Focus");
            Pokemon pok12 = new Pokemon("Machamp", 330, 60, 800, "None", "", "Titan Knuckle");
            Pokemon pok13 = new Pokemon("Incineroar", 310, 58, 770, "None", "", "Ember Lock");
            Pokemon pok14 = new Pokemon("Alakazam", 340, 40, 700, "None", "", "Mind Fracture");
            Pokemon pok15 = new Pokemon("Charizard", 300, 55, 760, "None", "", "Blaze Lance");
            Pokemon pok16 = new Pokemon("Raichu", 280, 50, 720, "None", "", "Volt Stunwave");
            Pokemon pok17 = new Pokemon("Maxikyu", 290, 60, 740, "None", "", "Cursed Snap");
            Pokemon pok18 = new Pokemon("Slowking", 250, 72, 780, "None", "", "Royal Hex");
            Pokemon pok19 = new Pokemon("Slowbro", 240, 75, 800, "None", "", "Neural Freeze");
            Pokemon pok20 = new Pokemon("Quagsire", 230, 65, 760, "None", "", "Mud Concussion");
            Pokemon pok21 = new Pokemon("Snorlax", 260, 78, 900, "None", "", "Gravity Drop");
            Pokemon pok22 = new Pokemon("Golduck", 240, 55, 720, "None", "", "Psyshock Torrent");
            Pokemon pok23 = new Pokemon("Lickilicky", 230, 60, 730, "None", "", "Coil Slam");
            Pokemon pok24 = new Pokemon("Bibarell", 200, 45, 650, "None", "", "Timber Bash");
            Pokemon pok25 = new Pokemon("Dugtrio", 220, 25, 620, "None", "", "Seismic Spike");

            Pokemon pok26 = new Pokemon("Neville", 180, 35, 600, "None", "", "Bitchass Hating");
            Pokemon pok27 = new Pokemon("Bryan", 175, 30, 580, "None", "", "Feet Feast");
            Pokemon pok28 = new Pokemon("Twinkerbell", 160, 25, 560, "None", "", "Stalk");
            Pokemon pok29 = new Pokemon("Twink", 150, 20, 540, "None", "", "goon");
            Pokemon pok30 = new Pokemon("Romeo??", 170, 30, 570, "None", "", "Call of the Voices");

            Pokemon pok31 = new Pokemon("Charmander", 120, 25, 360, "None", "", "Fire Breath");
            Pokemon pok32 = new Pokemon("Pikachu", 110, 20, 340, "None", "", "Lightning");
            Pokemon pok33 = new Pokemon("Wooper", 100, 30, 360, "None", "", "Mud Pop");
            Pokemon pok34 = new Pokemon("Eevee", 95, 28, 350, "None", "", "Adapt Burst");
            Pokemon pok35 = new Pokemon("Psyduck", 100, 25, 340, "None", "", "Head Pulse");
            Pokemon pok36 = new Pokemon("Bidoof", 90, 25, 330, "None", "", "Timber Nudge");
            Pokemon pok37 = new Pokemon("Diglett", 95, 15, 310, "None", "", "Burrow Sting");
            Pokemon pok38 = new Pokemon("Riolu", 120, 30, 370, "None", "", "Iron Spirit");
            Pokemon pok39 = new Pokemon("Machop", 130, 30, 380, "None", "", "Boulder Jab");
            Pokemon pok40 = new Pokemon("Litten", 115, 28, 360, "None", "", "Spark Claw");
            Pokemon pok41 = new Pokemon("Abra", 140, 10, 300, "None", "", "Mind Skip");
            Pokemon pok42 = new Pokemon("Slowpoke", 90, 35, 380, "None", "", "Lazy Slide");
            Pokemon pok43 = new Pokemon("Slakoth", 80, 20, 300, "None", "", "Aqua Flick");
            Pokemon pok44 = new Pokemon("Pichu", 70, 15, 260, "None", "", "Static Peep");
            PokeBase.All = new Pokemon[]
            {
                pok1,
                pok2,
                pok3,
                pok4,
                pok5,
                pok6,
                pok7,
                pok8,
                pok9,
                pok10,
                pok11,
                pok12,
                pok13,
                pok14,
                pok15,
                pok16,
                pok17,
                pok18,
                pok19,
                pok20,
                pok21,
                pok22,
                pok23,
                pok24,
                pok25,
                pok26,
                pok27,
                pok28,
                pok29,
                pok30,
                pok31,
                pok32,
                pok33,
                pok34,
                pok35,
                pok36,
                pok37,
                pok38,
                pok39,
                pok40,
                pok41,
                pok42,
                pok43,
                pok44,
            };
        }
    }
}
