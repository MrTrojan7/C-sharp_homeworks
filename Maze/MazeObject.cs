using System;
using System.Drawing;

namespace Maze
{
    class MazeObject
    {
        public enum MazeObjectType { HALL, WALL, MONEY, ENEMY, CHAR, FIRST_AID_KIT, CUP_COFFEE };

        public static Bitmap[] images = 
            {
                new Bitmap(@"E:\Step\.NET\C#\Maze\pics\hall.png"),
                new Bitmap(@"E:\Step\.NET\C#\Maze\pics\wall.png"),
                new Bitmap(@"E:\Step\.NET\C#\Maze\pics\medal.png"),
                new Bitmap(@"E:\Step\.NET\C#\Maze\pics\enemy.png"),
                new Bitmap(@"E:\Step\.NET\C#\Maze\pics\player.png"),
                new Bitmap(@"E:\Step\.NET\C#\Maze\pics\first_aid_kit.png"),
                new Bitmap(@"E:\Step\.NET\C#\Maze\pics\cup_coffee.png")
            };

        public MazeObjectType type;

        public MazeObject(MazeObjectType type)
        {
            this.type = type;
        }

    }
}
