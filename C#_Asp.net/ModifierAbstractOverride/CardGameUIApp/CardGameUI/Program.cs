using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CardGameUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What you want to do ? (Pokerdek / BlackJack)");
            Console.WriteLine("Enter P for PokerDeck Or B for BlackJack");
            string decision = Console.ReadLine();

            if (decision.ToLower() == "p")
            {
                PokerDeck deck = new PokerDeck();
                var hand = deck.DealCard();
                foreach (var card in hand)
                {
                    Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
                }
                Console.WriteLine();
            }
            else 
            {
                BlackJack blackJeckDeck = new BlackJack();
                var inHand = blackJeckDeck.DealCard();
                foreach (var card in inHand)
                {
                    Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
                }

                Console.WriteLine();
            }
            
            Console.ReadLine();
        }

    }
    public abstract class Deck
    {
        protected List<PlayingCardsModel> fullDeck = new List<PlayingCardsModel>();
        protected List<PlayingCardsModel> drawPile = new List<PlayingCardsModel>();
        protected List<PlayingCardsModel> discardPile = new List<PlayingCardsModel>();

        protected void CreateDeck()
        {
            fullDeck.Clear();
            for (int suit = 0; suit <4 ; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCardsModel { Suit = (CardSuit)suit, Value = (CardValue)val });
                }
            }
        }
        public virtual void ShuffleDeck()
        {
            //var rand = new Random();
            // var randomList = imageEasy.OrderBy(x => rand.Next()).ToList();
                
            var rnd = new Random();
            drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();
        }
        public abstract List<PlayingCardsModel> DealCard();
        protected virtual PlayingCardsModel DrawOneCard()
        {
        PlayingCardsModel output = drawPile.Take(1).First();
        drawPile.Remove(output);
        return output;
        }
    }
    public class PokerDeck : Deck
    {
        public PokerDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCardsModel> DealCard()
        {
            List<PlayingCardsModel> output = new List<PlayingCardsModel>();
            for (int i = 0; i < 5; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }
        public List<PlayingCardsModel> RequestCards(List<PlayingCardsModel> cardsToDiscards)
        {
            List<PlayingCardsModel> output = new List<PlayingCardsModel>();
            foreach (var card in cardsToDiscards)
            {
                output.Add(DrawOneCard());
                discardPile.Add(card);
            }
            return output;
        }

    }
    public class BlackJack : Deck
    {
        public BlackJack()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCardsModel> DealCard()
        {
            List<PlayingCardsModel> output = new List<PlayingCardsModel>();
            for (int i = 0; i < 2; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }
        public PlayingCardsModel RequestCard()
        {
            return DrawOneCard();   
        }
    }
}











//public int GetOrder(PlayingCards card)
//{
//    if (card.Suit == CardSuit.Clubs)
//    {
//        return 1;                                                =====>      x => rnd.Next()   "lamda Expression " 
//    }
//    else
//    {
//        return 0;
//    }