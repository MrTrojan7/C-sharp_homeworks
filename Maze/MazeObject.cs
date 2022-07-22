using System;
using System.Drawing;

namespace Maze
{
    class MazeObject
    {
        public enum MazeObjectType { HALL, WALL, MEDAL, ENEMY, CHAR };

        public Bitmap[] images = {new Bitmap(@"E:\Step\.NET\C#\Maze\pics\hall.png"),
            new Bitmap(@"E:\Step\.NET\C#\Maze\pics\wall.png"),
            new Bitmap(@"E:\Step\.NET\C#\Maze\pics\medal.png"),
            new Bitmap(@"E:\Step\.NET\C#\Maze\pics\enemy.png"),
            new Bitmap(@"E:\Step\.NET\C#\Maze\pics\player.png")};

        public MazeObjectType type;
        public int width;
        public int height;
        public Image texture;

        public MazeObject(MazeObjectType type)
        {
            this.type = type;
            width = 16;
            height = 16;
            texture = images[(int)type];
        }

    }
}
