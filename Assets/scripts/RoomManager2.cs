using UnityEngine;

public class RoomManager2 : MonoBehaviour
{
    public GameObject room1;
    public GameObject room2;
    public GameObject room3;

    public GameObject room1Hotspots;
    public GameObject room2Hotspots;
    public GameObject room3Hotspots;

    public void GoToRoom(GameObject targetRoom)
    {
        SetRoomActive(room1, room1Hotspots, room1 == targetRoom);
        SetRoomActive(room2, room2Hotspots, room2 == targetRoom);
        SetRoomActive(room3, room3Hotspots, room3 == targetRoom);
    }

    private void SetRoomActive(GameObject room, GameObject hotspots, bool active)
    {
        room.SetActive(active);
        if (hotspots != null)
        {
            hotspots.SetActive(active);
        }
    }
}