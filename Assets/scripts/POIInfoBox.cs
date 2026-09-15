using UnityEngine;

public class POIInfoBox : MonoBehaviour
{
    public GameObject infoBox;

    public void ToggleInfoBox()
    {
        infoBox.SetActive(!infoBox.activeSelf);
    }
}
