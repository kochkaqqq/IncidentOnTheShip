using GameCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Characters
{
    public class Player : Character
    {
        public string ModelPath { get; set; }
        public int[,] CheckBox { get; set; }

        public override void Moving(MoveDirection direction)
        {
            throw new NotImplementedException();
        }
    }
}
