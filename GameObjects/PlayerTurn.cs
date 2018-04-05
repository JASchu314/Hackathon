// Placeholder
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO.GameObjects
{
    public class PlayerTurn
    {
        public Card Card { get; set; }
        public CardColor DeclaredColor { get; set; }
        public TurnResult Result { get; set; }
    }
}