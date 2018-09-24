using System;
using System.Linq;

namespace MontyHall.Actor
{
    using Model;

    internal sealed class Host
    {
        private IBox[] _boxes;
        private byte _winningBoxNumber;
        private byte _contestantChoice;

        internal void PrepareBoxes(byte numberOfBoxes)
        {
            var randomizer = new Random();

            _boxes = new IBox[numberOfBoxes];
            for (var i = 0; i < numberOfBoxes; i++)
            {
                _boxes[i] = new EmptyBox();
            }

            _winningBoxNumber = (byte)randomizer.Next(numberOfBoxes);
            _boxes[_winningBoxNumber] = new Box(new MoneyContent(1000m));
        }

        internal void SelectContestantChoice(byte choice)
            => _boxes[(_contestantChoice = choice)].IsFlagged = true;

        internal void DiscardBox()
            => _boxes.First(b => b.IsEmpty && !b.IsFlagged).IsFlagged = true;

        internal ChoiceOutcome VerifyChoice()
            => (_contestantChoice == _winningBoxNumber) ? ChoiceOutcome.Won : ChoiceOutcome.Lost;

        internal ChoiceOutcome VerifyAlternativeChoice()
        {
            _contestantChoice = (byte)Array.FindIndex(_boxes, b => !b.IsFlagged);

            return (_contestantChoice == _winningBoxNumber) ? ChoiceOutcome.Won : ChoiceOutcome.Lost;
        }
    }
}
