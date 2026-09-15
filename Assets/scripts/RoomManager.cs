using UnityEngine;
using UnityEngine.Video;

public class RoomManager : MonoBehaviour
{
    public GameObject livingRoom;
    public GameObject cantina;
    public GameObject cube;
    public GameObject mezzanine;

    public GameObject livingRoomHotspots;
    public GameObject cantinaHotspots;
    public GameObject cubeHotspots;
    public GameObject mezzanineHotspots;

    public void GoToRoom(GameObject targetRoom)
    {
        SetRoomActive(livingRoom, livingRoomHotspots, livingRoom == targetRoom);
        SetRoomActive(cantina, cantinaHotspots, cantina == targetRoom);
        SetRoomActive(cube, cubeHotspots, cube == targetRoom);
        SetRoomActive(mezzanine, mezzanineHotspots, mezzanine == targetRoom);
    }

    private void SetRoomActive(GameObject room, GameObject hotspots, bool active)
    {
        room.SetActive(active);

        if (hotspots != null)
        {
            hotspots.SetActive(active);
        }

        VideoPlayer vp = room.GetComponent<VideoPlayer>();
        if (vp != null)
        {
            if (active)
            {
                vp.Play();
            }
            else
            {
                vp.Stop();
            }
        }
    }
}
