using UnityEngine;
using UnityEngine.SceneManagement;

public class SearchButtonController : MonoBehaviour
{
    public string resultsSceneName = "ResultsScene";

    public void OnSearchPressed()
    {
        SceneManager.LoadScene(resultsSceneName);
    }
}
