﻿using System;
using System.Collections.Generic;
using System.Drawing;
using BlazorGalaga.Models;

namespace BlazorGalaga.Interfaces
{
    public enum IntroLocation
    {
        None,
        Top,
        LowerLeft,
        LowerRight
    }

    public interface IIntro
    {
        public List<BezierCurve> GetPaths();
        public int Offset { get; set; }
        public bool IsChallenge { get; set; }
        public IntroLocation IntroLocation { get; set; }
    }
}
