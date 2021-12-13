using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    [Flags]
    internal enum ChessFigure
    {
        none = 0,
        King = 1,
        Queen = 2,
        Rock = 4,
        Bishop = 8,
        Horse = 16,
        Pawn = 32,
        Black = 64,

    }
}
