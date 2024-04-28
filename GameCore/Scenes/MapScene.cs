using GameCore.Characters;
using GameCore.Characters.Enemies;
using GameCore.Quests;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Scenes
{
    public class MapScene : Scene
    {
        public Player Player { get; set; }

        public List<Quest> Quests { get; set; }

        public string BackgroundPath { get; set; }

        public Bitmap Walls { get; set; }

        public Bitmap Floor { get; set; }

        public List<Enemy> Enemies { get; set; }

        public MapScene(Player player, List<Quest> quests, string filenameBackground, string filenameWalls, string filenameFloor, List<Enemy> enemies) 
        {
            Player = player;
            Quests = quests;
            Enemies = enemies;

        }
    }
}
