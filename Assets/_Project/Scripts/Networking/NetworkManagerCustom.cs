using Mirror;
using UnityEngine;

public class NetworkManagerCustom : NetworkManager
{
    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        Transform start = GetStartPosition();

        if (start == null)
            start = transform;

        GameObject player = Instantiate(playerPrefab, start.position, start.rotation);

        NetworkServer.AddPlayerForConnection(conn, player);
    }
}
