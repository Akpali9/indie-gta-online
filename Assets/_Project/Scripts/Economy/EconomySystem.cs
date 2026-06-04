using UnityEngine;

public class EconomySystem : MonoBehaviour
{
    public static EconomySystem Instance;

    public int money;

    void Awake()
    {
        Instance = this;
    }

    public void AddMoney(int amount)
    {
        money += amount;
    }

    public bool SpendMoney(int amount)
    {
        if (money < amount) return false;

        money -= amount;
        return true;
    }
}
