using UnityEngine;

public class CaseManager : MonoBehaviour
{
    public static CaseManager Instance;

    public CaseData[] cases;

    public int currentCaseIndex = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public CaseData GetCurrentCase()
    {
        return cases[currentCaseIndex];
    }

    public void LoadNextCase()
    {
        currentCaseIndex++;

        if (currentCaseIndex >= cases.Length)
            currentCaseIndex = 0; // or end game screen
    }

    public bool IsCorrectCulprit(CelebrityData reported)
    {
        return reported == cases[currentCaseIndex].culprit;
    }
}
