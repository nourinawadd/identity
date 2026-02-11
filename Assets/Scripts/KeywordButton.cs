using UnityEngine;

public class KeywordButton : MonoBehaviour
{
    public Transform originalParent;
    public Transform searchBarHolder;

    public int maxKeywords = 4;

    bool selected = false;

    public void ToggleKeyword()
    {
        // If trying to ADD keyword
        if (!selected)
        {
            if (searchBarHolder.childCount >= maxKeywords)
                return;

            transform.SetParent(searchBarHolder);
        }

        // If removing keyword
        else
        {
            transform.SetParent(originalParent);
        }

        selected = !selected;
    }
    public void ResetKeyword()
    {
        selected = false;
    }

}
