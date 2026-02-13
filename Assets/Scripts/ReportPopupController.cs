using UnityEngine;

public class ReportPopupController : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject popupPanel;
    public AudioClip popupSound;

    public void OpenPopup()
    {
        audioSource.PlayOneShot(popupSound);
        popupPanel.SetActive(true);
    }

    public void ClosePopup()
    {
        popupPanel.SetActive(false);
    }
}
