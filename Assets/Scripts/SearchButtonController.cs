using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SearchButtonController : MonoBehaviour
{
    public Transform searchBarHolder;
    public string resultsSceneName = "ResultsScene";

    public GameObject duplicateWarningPopup;

    public void OnSearchPressed()
    {
        // Track category counts
        Dictionary<KeywordCategory, int> categoryCount =
            new Dictionary<KeywordCategory, int>();

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

            // Count category usage
            if (!categoryCount.ContainsKey(btn.category))
                categoryCount[btn.category] = 0;

            categoryCount[btn.category]++;

            // If duplicate category → STOP + popup
            if (categoryCount[btn.category] > 1)
            {
                duplicateWarningPopup.SetActive(true);
                return;
            }

            // Save keyword
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

        // Optional: Prevent searching with zero keywords
        if (searchBarHolder.childCount == 0)
            return;

        SceneManager.LoadScene(resultsSceneName);
    }
}
