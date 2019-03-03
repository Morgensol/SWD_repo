using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

enum Color
{
    Red=1,
    Blue,
    Green,
    Yellow,
    NmbrOfColors
}
namespace CardGame
{
    public class card
    {
        public card()
        {
        }

        public int calculateValue()
        {
            return this.suit * this.number;
        }
        private int suit;
        private int number;
    }

    public class RedCard : card
    {
        public RedCard(int n)
        {
            this.suit = 1;
            number = n;
        }
    }
    public class GreenCard : card
    {
        public GreenCard(int n)
        {
            suit = 3;
            number = n;
        }
        private int suit;
        private int number;
    }
    public class BlueCard : card
    {
        public BlueCard(int n)
        {
            suit = 2;
            number = n;
        }
        private int suit;
        private int number;
    }
    public class YellowCard : card
    {
        public YellowCard(int n)
        {
            suit = 4;
            number = n;
        }
        private int suit;
        private int number;
    }
}
