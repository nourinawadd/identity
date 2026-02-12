using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ResultsManager : MonoBehaviour
{
    [Header("Database")]
    public CelebrityDatabase database;

    [Header("Filtered Results")]
    public List<CelebrityData> filteredResults = new List<CelebrityData>();

    [Header("UI - Keyword Display")]
    public Button hairBtn;
    public Button occupationBtn;
    public Button ethnicityBtn;
    public Button facialBtn;

    [Header("UI - Grid")]
    public Transform gridParent;
    public GameObject celebrityButtonPrefab;

    [Header("Inspector")]
    public CelebrityInspectorController inspectorController;

    void Start()
    {
        DisplaySelectedKeywords();
        FilterResults();
        PopulateGrid();
    }

    // ----------------------------
    // Show selected keywords
    // ----------------------------
    void DisplaySelectedKeywords()
    {
        hairBtn.GetComponentInChildren<TMP_Text>().text = SearchMemory.hair;
        occupationBtn.GetComponentInChildren<TMP_Text>().text = SearchMemory.occupation;
        ethnicityBtn.GetComponentInChildren<TMP_Text>().text = SearchMemory.ethnicity;
        facialBtn.GetComponentInChildren<TMP_Text>().text = SearchMemory.facial;
    }

    // ----------------------------
    // Filter Celebrities
    // ----------------------------
    void FilterResults()
    {
        filteredResults.Clear();

        foreach (CelebrityData celeb in database.celebrities)
        {
            bool match = true;

            if (!string.IsNullOrEmpty(SearchMemory.hair) &&
                celeb.hair != SearchMemory.hair)
                match = false;

            if (!string.IsNullOrEmpty(SearchMemory.occupation) &&
                celeb.occupation != SearchMemory.occupation)
                match = false;

            if (!string.IsNullOrEmpty(SearchMemory.ethnicity) &&
                celeb.ethnicity != SearchMemory.ethnicity)
                match = false;

            if (!string.IsNullOrEmpty(SearchMemory.facial) &&
                celeb.facial != SearchMemory.facial)
                match = false;

            if (match)
                filteredResults.Add(celeb);
        }

        Debug.Log("Matches found: " + filteredResults.Count);
    }


    // ----------------------------
    // Populate Grid
    // ----------------------------
    void PopulateGrid()
    {
        // Clear old buttons
        foreach (Transform child in gridParent)
            Destroy(child.gameObject);

        foreach (CelebrityData celeb in filteredResults)
        {
            Debug.Log("Spawning: " + celeb.celebrityName);
            GameObject buttonObj =
                Instantiate(celebrityButtonPrefab, gridParent);

            CelebrityButtonUI button =
                buttonObj.GetComponent<CelebrityButtonUI>();

            button.Setup(celeb, inspectorController);
        }
    }
}
