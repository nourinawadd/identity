using UnityEngine;
using System.Collections;

public class InfoPopupController : MonoBehaviour
{
    public GameObject popup;
    public float delayBeforeShow = 10f;
    public float visibleDuration = 4f;

    void Start()
    {
            StartCoroutine(ShowPopupRoutine());
    }

    IEnumerator ShowPopupRoutine()
    {
        yield return new WaitForSeconds(delayBeforeShow);

        popup.SetActive(true);

        yield return new WaitForSeconds(visibleDuration);

        popup.SetActive(false);
    }
}
