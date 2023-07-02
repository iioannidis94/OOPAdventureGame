﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdventure;

internal class Gold : Item
{
    public Gold(int value)
    {
        Value = value;
        CanTake = true;


    }
    
    public override string Name
    {
        get
        {
            var ending = Value == 1 ? Text.Language.Coin : Text.Language.Coins;

            return string.Format(Text.Language.Gold, Value.ToString(), ending);
        }
    }

    public int Value { get; private set; }

}

