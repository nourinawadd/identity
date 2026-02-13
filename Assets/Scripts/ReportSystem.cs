using UnityEngine;

public class ReportSystem : MonoBehaviour
{
    public CelebrityInspectorController inspector;
    public VerdictController verdictController;

    public void ReportSuspect()
    {
        CelebrityData selected =
            inspector.GetCurrentCelebrity();

        bool correct =
            CaseManager.Instance.IsCorrectCulprit(selected);

        verdictController.ShowVerdict(selected, correct);
    }
}
