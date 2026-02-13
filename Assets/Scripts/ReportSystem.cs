using UnityEngine;

public class ReportSystem : MonoBehaviour
{
    public CelebrityInspectorController inspector;

    public GameObject winScreen;
    public GameObject loseScreen;

    public void ReportSuspect()
    {
        CelebrityData selected =
            inspector.GetCurrentCelebrity();

        bool correct =
            CaseManager.Instance.IsCorrectCulprit(selected);

        if (correct)
        {
            winScreen.SetActive(true);
        }
        else
        {
            loseScreen.SetActive(true);
        }
    }
}
