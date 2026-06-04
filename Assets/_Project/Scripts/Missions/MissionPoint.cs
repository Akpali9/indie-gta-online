using UnityEngine;

public class MissionPoint : MonoBehaviour
{
    public int reward = 100;
    bool completed;

    void OnTriggerEnter(Collider other)
    {
        if (completed) return;

        if (other.CompareTag("Player"))
        {
            completed = true;
            EconomySystem.Instance.AddMoney(reward);
        }
    }
}
