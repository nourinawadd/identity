using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CelebrityInspectorController : MonoBehaviour
{
    public GameObject panelRoot;

    public Image celebrityImage;
    public TMP_Text inspectorDetails;

    private CelebrityData currentCelebrity;
    public Animator animator;


    public void ShowCelebrity(CelebrityData celeb)
    {
        currentCelebrity = celeb;

        // Populate UI
        celebrityImage.sprite = celeb.portrait;

        inspectorDetails.text =
            "Name: " + celeb.celebrityName + "\n\n" +
            "Occupation: " + celeb.occupation + "\n" +
            "Ethnicity: " + celeb.ethnicity + "\n";

        panelRoot.SetActive(true);
        animator.SetBool("IsOpen", true);
    }

    public CelebrityData GetCurrentCelebrity()
    {
        return currentCelebrity;
    }

    public void CloseInspector()
    {
        animator.SetBool("IsOpen", false);
    }
}
