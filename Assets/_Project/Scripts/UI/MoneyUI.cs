using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Update()
    {
        text.text = "$ " + EconomySystem.Instance.money;
    }
}
