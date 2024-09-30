using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public CardDisplay cardDisplay;
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
        Card newCard = new Card("Copper", 0, "+1 Money");
        deck1.AddCard(newCard);
        cardDisplay.SetCard(newCard);

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