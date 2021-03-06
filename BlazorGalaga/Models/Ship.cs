﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using BlazorGalaga.Interfaces;

namespace BlazorGalaga.Models
{
    public class Ship : AnimatableBase
    {
        public bool IsFiring { get; set; }
        public bool Disabled { get; set; }
        public bool  IsExploding { get; set; }

        public bool HasExploded { get; set; }

        public bool LeftShipHit { get; set; }

        public bool RightShipHit { get; set; }

        public bool IsDoubleShip { get; set; }

        public Ship() 
        {
            Sprite = new Sprite(Sprite.SpriteTypes.Ship);
            AllowNegativeSpeed = true;
        }
    }
}
