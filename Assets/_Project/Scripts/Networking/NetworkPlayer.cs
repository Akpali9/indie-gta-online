using Mirror;
using UnityEngine;

public class NetworkPlayer : NetworkBehaviour
{
    public float speed = 5f;

    void Update()
    {
        if (!isLocalPlayer) return;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, 0, z);
        transform.Translate(move * speed * Time.deltaTime);
    }
}
