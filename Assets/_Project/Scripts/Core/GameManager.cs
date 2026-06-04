using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int wantedLevel;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void AddWanted(int value)
    {
        wantedLevel = Mathf.Clamp(wantedLevel + value, 0, 5);
    }

    public void ResetWanted()
    {
        wantedLevel = 0;
    }
}
