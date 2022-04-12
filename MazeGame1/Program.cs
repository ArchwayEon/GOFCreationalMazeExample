// See https://aka.ms/new-console-template for more information
using MazeAbstractFactory;
using MazeBuilderLib;
using MazeGame1;
using MazeGame2;
using MazeLib;

Console.WriteLine("Maze Game");

MazeGame game = new();
game.CreateMaze("Maze 1");

Console.WriteLine("Maze 1");
Room? currentRoom = game.Maze!.GetRoom(1);
currentRoom!.Enter();
Console.WriteLine(currentRoom.Message);
MapSite location = currentRoom.GetSide(Direction.East);
location.Enter();
Console.WriteLine(location.Message);
location = currentRoom.GetSide(Direction.North);
location.Enter();
Console.WriteLine(location.Message);

Console.WriteLine("Maze 2");
game.CreateMaze("Maze 2", new MazeFactory());
currentRoom = game.Maze!.GetRoom(1);
currentRoom!.Enter();
Console.WriteLine(currentRoom.Message);
location = currentRoom.GetSide(Direction.East);
location.Enter();
Console.WriteLine(location.Message);
location = currentRoom.GetSide(Direction.North);
location.Enter();
Console.WriteLine(location.Message);

Console.WriteLine("Maze 3");
game.CreateMaze("Maze 3", new EnchantedMazeFactory());
currentRoom = game.Maze!.GetRoom(1);
currentRoom!.Enter();
Console.WriteLine(currentRoom.Message);
location = currentRoom.GetSide(Direction.East);
location.Enter();
Console.WriteLine(location.Message);
location = currentRoom.GetSide(Direction.North);
location.Enter();
Console.WriteLine(location.Message);

Console.WriteLine("Maze 4");
game.CreateMaze("Maze 4", new StandardMazeBuilder());
currentRoom = game.Maze!.GetRoom(1);
currentRoom!.Enter();
Console.WriteLine(currentRoom.Message);
location = currentRoom.GetSide(Direction.East);
location.Enter();
Console.WriteLine(location.Message);
location = currentRoom.GetSide(Direction.North);
location.Enter();
Console.WriteLine(location.Message);

MazeFactory2 factory = new MazeFactory2();
Console.WriteLine("Maze 5");
factory.CreateMaze("Maze 5");
currentRoom = factory.Maze!.GetRoom(1);
currentRoom!.Enter();
Console.WriteLine(currentRoom.Message);
location = currentRoom.GetSide(Direction.East);
location.Enter();
Console.WriteLine(location.Message);
location = currentRoom.GetSide(Direction.North);
location.Enter();
Console.WriteLine(location.Message);

