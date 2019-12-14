﻿using System;
namespace Roguelike
{
    class TileFlyweight
    {
        public string Name { get; }
        public string Description { get; }
        public char Symbol { get; }
        public Type TileType { get; }
        public BaseEntity Object { get; set; }

        public enum Type
        {
            Wall = 0,
            Ground = 1,
            Water = 2,
            Lava = 3
        }

        public TileFlyweight(string name, string description, char symbol, Type type, BaseEntity obj = null)
        {
            Name = name;    
            Description = description;
            Symbol = symbol;
            TileType = type;
            Object = obj;
        }
    }
}
