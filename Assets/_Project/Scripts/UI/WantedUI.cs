using TMPro;
using UnityEngine;

public class WantedUI : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Update()
    {
        text.text = "Wanted: " + GameManager.Instance.wantedLevel;
    }
}
