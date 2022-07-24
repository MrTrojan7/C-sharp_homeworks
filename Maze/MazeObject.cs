using System;
using System.Drawing;

namespace Maze
{
    class MazeObject
    {
        public enum MazeObjectType { HALL, WALL, MEDAL, ENEMY, CHAR };

        public static Bitmap[] images = 
            {
                new Bitmap(@"E:\Step\.NET\C#\Maze\pics\hall.png"),
                new Bitmap(@"E:\Step\.NET\C#\Maze\pics\wall.png"),
                new Bitmap(@"E:\Step\.NET\C#\Maze\pics\medal.png"),
                new Bitmap(@"E:\Step\.NET\C#\Maze\pics\enemy.png"),
                new Bitmap(@"E:\Step\.NET\C#\Maze\pics\player.png")
            };

        public MazeObjectType type;

        public MazeObject(MazeObjectType type)
        {
            this.type = type;
        }

    }
}
