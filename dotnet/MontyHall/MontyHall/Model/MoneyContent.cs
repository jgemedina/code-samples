namespace MontyHall.Model
{
    internal sealed class MoneyContent : BoxContent
    {
        private readonly decimal _amount;

        internal MoneyContent(decimal amount)
        {
            _amount = amount;
        }

        protected internal override string Value
        {
            get => $"{_amount} :-";
        }
    }
}
