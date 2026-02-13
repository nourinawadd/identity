using UnityEngine;

public class CaseManager : MonoBehaviour
{
    public static CaseManager Instance;

    public CaseData currentCase;

    private void Awake()
    {
        Instance = this;
    }

    public bool IsCorrectCulprit(CelebrityData reported)
    {
        return reported == currentCase.culprit;
    }
}
