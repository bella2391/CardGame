using UnityEngine;
using TMPro; // TextMeshProの名前空間を追加

public class CardDisplay : MonoBehaviour {
    public TMP_Text nameText; // TextからTMP_Textに変更
    public TMP_Text costText; // TextからTMP_Textに変更
    public TMP_Text effectText; // TextからTMP_Textに変更

    private Card card;

    public void SetCard(Card card) {
        this.card = card;
        nameText.text = card.Name;
        costText.text = card.Cost.ToString();
        effectText.text = card.Effect;
    }
}