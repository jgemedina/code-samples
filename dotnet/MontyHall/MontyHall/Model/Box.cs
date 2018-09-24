using System;

namespace MontyHall.Model
{
    internal class Box : IBox
    {
        private readonly BoxContent _content;

        protected internal Box(BoxContent content)
        {
            _content = content;
        }

        public bool IsEmpty
        {
            get => _content is NoContent;
        }

        public bool IsFlagged { get; set; }
    } 
}