namespace MontyHall.Model
{
    internal sealed class EmptyBox : Box
    {
        internal EmptyBox() : base(new NoContent())
        {
        }
    }
}
