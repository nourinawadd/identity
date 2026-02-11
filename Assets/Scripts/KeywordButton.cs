using UnityEngine;
public enum KeywordCategory
{
    Hair,
    Occupation,
    Ethnicity,
    Facial
}

public class KeywordButton : MonoBehaviour
{
    public Transform originalParent;
    public Transform searchBarHolder;

    public KeywordCategory category;
    public string keywordValue;

    bool selected = false;

    public void ToggleKeyword()
    {
        if (!selected)
            transform.SetParent(searchBarHolder);
        else
            transform.SetParent(originalParent);

        selected = !selected;
    }
    public void ResetKeyword()
    {
        selected = false;
    }

}
