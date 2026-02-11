using System.Collections.Generic;
using UnityEngine;

public class ResultsManager : MonoBehaviour
{
    public CelebrityDatabase database;

    public List<CelebrityData> filteredResults = new List<CelebrityData>();

    void Start()
    {
        FilterResults();
    }

    void FilterResults()
    {
        filteredResults.Clear();

        foreach (CelebrityData celeb in database.celebrities)
        {
            if (celeb.hair == SearchMemory.hair &&
                celeb.occupation == SearchMemory.occupation &&
                celeb.ethnicity == SearchMemory.ethnicity &&
                celeb.facial == SearchMemory.facial)
            {
                filteredResults.Add(celeb);
            }
        }

        Debug.Log("Matches found: " + filteredResults.Count);
    }
}
