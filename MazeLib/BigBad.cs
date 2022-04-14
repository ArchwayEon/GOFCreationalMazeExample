using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib;

public class BigBad
{
    public string Name { get; set; } = String.Empty;
    private static BigBad? _instance = null;

    private BigBad()
    {
    }

    public static BigBad Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new BigBad();
            }
            return _instance;
        }
    }
}
