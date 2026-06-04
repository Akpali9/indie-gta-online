using UnityEngine;

public class PoliceAI : MonoBehaviour
{
    public Transform target;
    public float speed = 4f;

    void Update()
    {
        if (!target) return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );
    }
}
