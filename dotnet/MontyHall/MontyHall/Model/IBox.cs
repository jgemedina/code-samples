namespace MontyHall.Model
{
    internal interface IBox
    {
        bool IsEmpty { get; }

        bool IsFlagged { get; set; }
    }
}