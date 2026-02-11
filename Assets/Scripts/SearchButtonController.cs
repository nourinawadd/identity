using UnityEngine;
using UnityEngine.SceneManagement;

public class SearchButtonController : MonoBehaviour
{
    public Transform searchBarHolder;
    public string resultsSceneName = "Results";

    public void OnSearchPressed()
    {
        // Reset memory
        SearchMemory.hair = "";
        SearchMemory.occupation = "";
        SearchMemory.ethnicity = "";
        SearchMemory.facial = "";

        foreach (Transform keyword in searchBarHolder)
        {
            KeywordButton btn = keyword.GetComponent<KeywordButton>();

            if (btn == null)
                continue;

            // Save category → memory
            switch (btn.category)
            {
                case KeywordCategory.Hair:
                    SearchMemory.hair = btn.keywordValue;
                    break;

                case KeywordCategory.Occupation:
                    SearchMemory.occupation = btn.keywordValue;
                    break;

                case KeywordCategory.Ethnicity:
                    SearchMemory.ethnicity = btn.keywordValue;
                    break;

                case KeywordCategory.Facial:
                    SearchMemory.facial = btn.keywordValue;
                    break;
            }
        }

        SceneManager.LoadScene(resultsSceneName);
    }
}
