using System;

namespace MontyHall.Model
{
    internal class ContestResult
    {
        internal Guid RunID { get; set; }
        internal ChoiceOutcome ChoiceOutcome { get; set; }

        internal ContestantDecision ContestantDecision { get; set; }

        public ContestResult(Guid runID, ChoiceOutcome outcome, ContestantDecision decision)
        {
            RunID = runID;
            ChoiceOutcome = outcome;
            ContestantDecision = decision;
        }

        public override string ToString()
        => $"{RunID}: Contestant choose to '{ContestantDecision}' and '{ChoiceOutcome}'";
    }
}
