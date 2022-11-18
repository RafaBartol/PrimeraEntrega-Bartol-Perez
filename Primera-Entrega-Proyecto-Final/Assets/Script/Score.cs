using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int CoinsCollected = 0;
    public TMP_Text score;

    void Update()
    {
        score.text = "Coins: " + CoinsCollected + " de " + 22;
    }
}
