using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        static int CardValue(string card)
        {
            int cardValue;
            int firstCard = 0;
            char[] cards = card.ToCharArray();
            switch (cards[0])
            {
                case '1':
                    firstCard = 10;
                    break;
                case 'J':
                    firstCard = 11;
                    break;
                case 'Q':
                    firstCard = 12;
                    break;
                case 'K':
                    firstCard = 13;
                    break;
                case 'A':
                    firstCard = 14;
                    break;
                default:
                    firstCard = (int)Char.GetNumericValue(cards[0]);
                    break;
            }
            switch (cards[cards.Length-1])
            {

                case 'S':
                    cards[cards.Length - 1] = '4';
                    break;
                case 'H':
                    cards[cards.Length - 1] = '3';
                    break;
                case 'D':
                    cards[cards.Length - 1] = '2';
                    break;
                case 'C':
                    cards[cards.Length - 1] = '1';
                    break;
                default:
                    break;
            }

            cardValue = firstCard * (int)Char.GetNumericValue(cards[cards.Length - 1]);
            return cardValue;
        }

        static void AddCardsToPerson(Dictionary<string,int> person, string[] cardArgs)
        {
            foreach (var card in cardArgs)
            {
                if (!person.ContainsKey(card))
                {
                    person.Add(card, CardValue(card));
                }
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var people = new Dictionary<string, Dictionary<string, int>>();
            var playerCards = new Dictionary<string, int>();


            while (input != "JOKER")
            {
                var commandArgs = input.Split(':');
                var name = commandArgs[0];
                var cardsArgs = commandArgs[1].Trim().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (!people.ContainsKey(name))
                {
                    people.Add(name, new Dictionary<string, int>());
                    AddCardsToPerson(people[name], cardsArgs);

                }
                else
                {
                    AddCardsToPerson(people[name], cardsArgs);
                }
                input = Console.ReadLine();
            }

            foreach (var name in people)
            {
                Console.WriteLine(name.Key + ": " + name.Value.Values.Sum());
            }

        }


    }
}
