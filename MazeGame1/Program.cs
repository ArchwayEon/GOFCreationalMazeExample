// See https://aka.ms/new-console-template for more information
using MazeAbstractFactory;
using MazeBuilderLib;
using MazeGameConsole;
using MazeFactoryMethodLib;
using MazeLib;
using MazePrototype;

Console.WriteLine("Maze Game");

BigBad.Instance.Name = "Singleton Boss";

MazeGameCreator game = new();
game.CreateMaze("Maze 1");

Console.WriteLine("\nMaze 1");
Room? currentRoom = game.Maze!.GetRoom(1);
currentRoom!.Enter();
Console.WriteLine(currentRoom.Message);
MapSite location = currentRoom.GetSide(Direction.East);
location.Enter();
Console.WriteLine(location.Message);
location = currentRoom.GetSide(Direction.North);
location.Enter();
Console.WriteLine(location.Message);

Console.WriteLine("\nMaze 2");
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

Console.WriteLine("\nMaze 3");
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


Console.WriteLine("\nMaze 4");
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

MazeFactoryMethod factory = new MazeFactoryMethod();
Console.WriteLine("\nMaze 5");
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

Console.WriteLine("\nMaze 6");
Maze baseMaze = new Maze();
Room? baseRoom = new EnchantedRoom();
Wall? baseWall = new Wall();
Door? baseDoor = new EnchantedDoor();

game.CreateMaze("Maze 6",
    new MazePrototypeFactory(
        baseMaze, baseRoom, baseWall!, baseDoor!));
currentRoom = game.Maze!.GetRoom(1);
currentRoom!.Enter();
Console.WriteLine(currentRoom.Message);
location = currentRoom.GetSide(Direction.East);
location.Enter();
Console.WriteLine(location.Message);
location = currentRoom.GetSide(Direction.North);
location.Enter();
Console.WriteLine(location.Message);

