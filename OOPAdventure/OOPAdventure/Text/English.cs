using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OOPAdventure;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, what is your name?";
        DeafaultName = "No Name";
        Welcome = "Welcome {0} to your OOP Adventure!";
        DeafaultRoomName = "Room {0} ({1}, {2})";
        DeafaultRoomDescription = " You are in a {0} room with doors to the {1}.";
        ActionError = "You can't do that!";
        Go = "Go";
        GoError = "You can't go that way!";
        WhatToDo = "What do you want to do?";
        Quit = "quit";
        RoomNew = "You entered {0}";
        RoomOld = "You returned to {0}";
        And = "and";
        Comma = ",";
        Space = " ";
        RoomDescriptions = new List<string>
        {
            "normal",
            "cold",
            "warm",
            "dark",
            "bright",
            "scary",
            "strange"

        };

        NoItem = "You don't have {0}.";

        Backpack = "Backpack";
        BackpackError = "You don't have anything in your backpack.";
        BackpackDescription = "Your backpack contains: {0}.";

        Chest = "chest";
        ChestFound = "You found: {0}";
        ChestEmpty = "The chest is empty.";
        UnlockChest = "You unlocked the chest.";
        Key = "key";


    }
}

