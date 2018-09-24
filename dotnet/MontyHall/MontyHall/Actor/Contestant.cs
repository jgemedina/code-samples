using System;

namespace MontyHall.Actor
{
    internal class Contestant
    {
        internal byte PickBox()
        {
            var random = new Random();

            return (byte)random.Next(2);
        }

        internal bool ChangeChoice()
        {
            var random = new Random();

            return random.Next(2) == 1;
        }
    }
}
