using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdventure;

public abstract class Characters
{
    public string Name { get; set; }

    public Characters(string name)
    {
        Name = name;
    }
}