using MazeAbstractFactory;
using MazeBuilderLib;
using MazeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame1;

public class MazeGame
{
    public Maze? Maze { get; set; }

    public void CreateMaze(string name)
    {
        Maze = new Maze
        {
            Name = name,
        };
        Room r1 = new(1);
        Room r2 = new(2);
        Door door = new(r1, r2);

        Maze.AddRoom(r1);
        Maze.AddRoom(r2);

        r1.SetSide(Direction.North, new Wall());
        r1.SetSide(Direction.East, door);
        r1.SetSide(Direction.South, new Wall());
        r1.SetSide(Direction.West, new Wall());

        r2.SetSide(Direction.North, new Wall());
        r2.SetSide(Direction.East, new Wall());
        r2.SetSide(Direction.South, new Wall());
        r2.SetSide(Direction.West, door);
    }

    public void CreateMaze(string name, MazeFactory mazeFactory)
    {
        Maze = mazeFactory.MakeMaze(name);
        Room r1 = mazeFactory.MakeRoom(1);
        Room r2 = mazeFactory.MakeRoom(2);
        Door door = mazeFactory.MakeDoor(r1, r2);

        Maze.AddRoom(r1);
        Maze.AddRoom(r2);

        r1.SetSide(Direction.North, mazeFactory.MakeWall());
        r1.SetSide(Direction.East, door);
        r1.SetSide(Direction.South, mazeFactory.MakeWall());
        r1.SetSide(Direction.West, mazeFactory.MakeWall());

        r2.SetSide(Direction.North, mazeFactory.MakeWall());
        r2.SetSide(Direction.East, mazeFactory.MakeWall());
        r2.SetSide(Direction.South, mazeFactory.MakeWall());
        r2.SetSide(Direction.West, door);
    }

    public void CreateMaze(string name, MazeBuilder mazeBuilder)
    {
        mazeBuilder.BuildMaze(name);
        mazeBuilder.BuildRoom(1);
        mazeBuilder.BuildRoom(2);
        mazeBuilder.BuildDoor(1, 2);
        Maze = mazeBuilder.GetMaze();
    }
}
