using UnityEngine;

public class VehicleEnterExit : MonoBehaviour
{
    public GameObject player;
    public Transform seat;

    bool inVehicle;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleVehicle();
        }
    }

    void ToggleVehicle()
    {
        inVehicle = !inVehicle;

        player.SetActive(!inVehicle);

        if (inVehicle)
        {
            player.transform.position = seat.position;
        }
    }
}
