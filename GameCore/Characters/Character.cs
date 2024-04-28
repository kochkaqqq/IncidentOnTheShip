using GameCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Characters
{
    public abstract class Character
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public abstract void Moving(MoveDirection direction);
    }
}
