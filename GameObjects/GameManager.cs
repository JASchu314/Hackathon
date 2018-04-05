using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO.GameObjects{
    public class GameManager{
        public List<Player> Players {get; set;}
        public CardDeck DrawPile {get; set;}
        public List<Card> DiscardPile{get;set;}
    }
}