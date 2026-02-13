using UnityEngine;

public class UIButtonSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clickSoundIn;
    public AudioClip clickSoundOut;
    public AudioClip caseOpen;
    public AudioClip caseClose;

    public void PlayClickIn()
    {
        audioSource.PlayOneShot(clickSoundIn);
    }
    public void PlayClickOut()
    {
        audioSource.PlayOneShot(clickSoundOut);
    }
    public void PlayCaseOpen()
    {
        audioSource.PlayOneShot(caseOpen);
    }
    public void PlayCaseClose()
    {
        audioSource.PlayOneShot(caseClose);
    }
}
