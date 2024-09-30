using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardGame {
    public class Player {
        public string Name { get; private set; }
        public int Money { get; private set; }
        public int Actions { get; private set; }
        public int Buys { get; private set; }
        private Deck deck;
        private List<Card> hand = new List<Card>();
        private List<Card> discardPile = new List<Card>();

        public Player(string name, Deck deck) {
            Name = name;
            Money = 0;
            Actions = 1;
            Buys = 1;
            this.deck = deck;
            DrawHand();
        }

        public void DrawHand() {
            for (int i = 0; i < 5; i++) {
                Card card = deck.DrawCard();
                if (card != null) {
                    hand.Add(card);
                }
            }
        }

        public void PlayTurn() {
            // プレイヤーのターンのロジックをここに追加
        }

        public void BuyCard(Card card) {
            if (Money >= card.Cost && Buys > 0) {
                Money -= card.Cost;
                Buys--;
                discardPile.Add(card);
            }
        }
    }
}