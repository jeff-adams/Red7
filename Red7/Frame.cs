using System;
using System.Drawing;

namespace Red7
{
    public interface IFrame
    {
        public Rectangle Area { get; }
        public bool IsChanged { get; }
        public void DrawContents();
    }
}