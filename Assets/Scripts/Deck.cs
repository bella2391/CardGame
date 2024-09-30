using System.Collections.Generic;
using UnityEngine;

namespace CardGame {
    public class Deck {
        private List<Card> cards = new List<Card>();

        public void AddCard(Card card) {
            cards.Add(card);
        }

        public Card DrawCard() {
            if (cards.Count == 0) return null;
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public void Shuffle() {
            for (int i = 0; i < cards.Count; i++) {
                Card temp = cards[i];
                int randomIndex = Random.Range(i, cards.Count);
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
            }
        }
    }
}