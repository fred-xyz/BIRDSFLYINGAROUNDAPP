﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BIRDSFLYINGAROUNDAPP
{
    public abstract class Bird
    {
        public abstract void SetLocation(double longitude, double latitude);
        
        public abstract void Draw();
    }
}
