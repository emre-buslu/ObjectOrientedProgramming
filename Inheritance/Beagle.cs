using System;

namespace Inheritance
{
    public sealed class Beagle : Dog
    {
        public void Play()
        {
            Console.WriteLine($"Let's play the game, {base.Name}!");
        }

        public void Breathing()
        {
            base.Breath();
        }

        //public override void Meet()
        //{
        //
        //}

    }
}
