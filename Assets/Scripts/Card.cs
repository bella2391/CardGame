using System;
using System.Collections.Generic;
using UnityEngine;

public class Card {
    public string Name { get; private set; }
    public int Cost { get; private set; }
    public string Effect { get; private set; }

    public Card(string name, int cost, string effect) {
        Name = name;
        Cost = cost;
        Effect = effect;
    }
}

public class Deck {
    private List<Card> cards = new List<Card>();

    public void AddCard(Card card) {
        cards.Add(card);
    }

    public void Shuffle() {
        System.Random rng = new System.Random();
        int n = cards.Count;
        while (n > 1) {
            n--;
            int k = rng.Next(n + 1);
            Card value = cards[k];
            cards[k] = cards[n];
            cards[n] = value;
        }
    }

    public Card DrawCard() {
        if (cards.Count == 0) return null;
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}

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

public class Game : MonoBehaviour {
    private List<Player> players = new List<Player>();
    private List<Card> boardCards = new List<Card>();

    void Start() {
        // ゲームの初期化
        InitializeGame();
    }

    void InitializeGame() {
        // プレイヤーとデッキの初期化
        Deck deck1 = new Deck();
        Deck deck2 = new Deck();
        // デッキにカードを追加
        // 例: deck1.AddCard(new Card("Warrior", 10, "Attack"));
        // プレイヤーを追加
        players.Add(new Player("Player 1", deck1));
        players.Add(new Player("Player 2", deck2));

        // 盤面のカードを初期化
        // 例: boardCards.Add(new Card("Village", 3, "Gain 2 Actions"));

        // ゲームの進行を開始
        StartGame();
    }

    void StartGame() {
        // ゲームのメインループ
        while (true) {
            foreach (Player player in players) {
                player.PlayTurn();
                // ターンの終了処理
            }
        }
    }
}