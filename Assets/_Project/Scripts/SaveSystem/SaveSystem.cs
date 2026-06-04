using System.IO;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int money;
}

public class SaveSystem : MonoBehaviour
{
    public EconomySystem eco;

    public void SaveGame()
    {
        PlayerData data = new PlayerData();
        data.money = eco.money;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/save.json", json);
    }

    public void LoadGame()
    {
        string path = Application.persistentDataPath + "/save.json";

        if (!File.Exists(path)) return;

        PlayerData data = JsonUtility.FromJson<PlayerData>(
            File.ReadAllText(path)
        );

        eco.money = data.money;
    }
}
