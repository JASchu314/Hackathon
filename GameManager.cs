using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO.GameObjects{
    public class GameManager{
        public List<Player> Players { get; set; }
        public CardDeck DrawPile  { get; set; }
        public List<Card> DiscardPile{ get; set; }

        public GameManager(int numPlayers){
            Players = new List<Player>();
            DrawPile = new CardDeck();
            DrawPile.Shuffle();

            for ( int i = 1; i <= numPlayers; i++ ){
                Players.Add(new Player(){
                    Position = i
                });
            }

            int maxCards = 7 * Players.Count;
            int dealtCards = 0;

            while( dealtCards < maxCards ){
                for ( int i = 0; i < numPlayers; i++ ){
                    Players[i].Hand.Add( DrawPile.Cards.First());
                    DrawPile.Cards.RemoveAt(0);
                    dealtCards++;
                }
            }

            DiscardPile = new List<Card>();
            DiscardPile.Add( DrawPile.Cards.First());
            DrawPile.Cards.RemoveAt(0);

            while( DiscardPile.First().Value == CardValue.Wild || DiscardPile.First().Value == CardValue.DrawFour){
                DiscardPile.Insert( 0, DrawPile.Cards.First());
                DrawPile.Cards.RemoveAt(0);
            }
        }

        ///$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$



    }
}