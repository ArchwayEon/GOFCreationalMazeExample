using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib;

public class Room : MapSite
{
    public BigBad? BigBad { get; set; }
    private Random _random = new Random();
    private readonly Dictionary<Direction, MapSite> _sides 
        = new();
    public int RoomNumber { get; set; }

    public Room()
    {
        Initialize();
    }

    public Room(int roomNumber)
    {
        RoomNumber = roomNumber;
        Initialize();
    }

    public Room(Room copy)
    {
        RoomNumber = copy.RoomNumber;
        _sides = new();
        foreach (KeyValuePair<Direction, MapSite> entry in copy._sides)
        {
            Direction direction = entry.Key;
            var value = entry.Value.Clone();
            _sides[direction] = value;
        }
        // No need to copy the BigBad
    }

    protected void Initialize()
    {
        var number = _random.Next(2);
        if(number == 1)
        {
            Message += $"The BigBad {BigBad.Instance.Name} is here! ";
        }
    }

    public MapSite GetSide(Direction direction)
    {
        return _sides[direction];
    }

    public void SetSide(Direction direction, MapSite site)
    {
        _sides[direction] = site;
    }

    public override void Enter()
    {
        Message += "You entered a room. ";
        
    }

    public override MapSite Clone()
    {
        return new Room(this);
    }
}
