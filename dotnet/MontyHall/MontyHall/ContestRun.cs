using System;

namespace MontyHall
{
    using Model;
    using Actor;

    internal sealed class ContestRun
    {
        private readonly Host _host;
        private readonly Contestant _contestant;

        internal ContestRun(Host host, Contestant contestant)
        {
            _host = host;
            _contestant = contestant;
        }

        internal ContestResult Run()
        {
            _host.PrepareBoxes(3);
            _host.SelectContestantChoice(_contestant.PickBox());
            _host.DiscardBox();

            Guid runID = Guid.NewGuid();
            if (!_contestant.ChangeChoice())
            {
                return new ContestResult(runID, _host.VerifyChoice(), ContestantDecision.Stay);
            }

            return new ContestResult(runID, _host.VerifyAlternativeChoice(), ContestantDecision.Change);
        }
    }
}