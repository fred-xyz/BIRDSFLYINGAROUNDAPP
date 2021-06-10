using System;
using System.Collections.Generic;
using System.Text;

namespace BIRDSFLYINGAROUNDAPP
{
    public class owl : TheyCanFly
    {
        public override void SetLocation(double longitude, double latitude)
        {
            //sæt en lokation
        }

        public override void SetAltitude(double altitude)
        {
            //Denne metode vil aldrig blive implementeret for en pingvin
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            //Tegn fuglen på skærmen
        }
    }
}
