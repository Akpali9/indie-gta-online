using UnityEngine;
using Mirror;

public class LobbyUI : MonoBehaviour
{
    public NetworkManager manager;

    public void HostGame()
    {
        manager.StartHost();
    }

    public void JoinGame()
    {
        manager.StartClient();
    }

    public void StopGame()
    {
        manager.StopHost();
    }
}
