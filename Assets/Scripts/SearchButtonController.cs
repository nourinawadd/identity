using UnityEngine;
using UnityEngine.SceneManagement;

public class SearchButtonController : MonoBehaviour
{
    public string resultsSceneName = "ResultsScene";
    public string hair;
    public string occupation;
    public string ethnicity;
    public string facial;

    public void SaveSearch()
    {
        SearchMemory.hair = hair;
        SearchMemory.occupation = occupation;
        SearchMemory.ethnicity = ethnicity;
        SearchMemory.facial = facial;
    }
    public void OnSearchPressed()
    {
        SaveSearch();
        SceneManager.LoadScene(resultsSceneName);
    }
}
