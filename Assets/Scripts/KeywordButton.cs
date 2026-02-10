using UnityEngine;

public class KeywordButton : MonoBehaviour
{
    public Transform originalParent;
    public Transform searchBarHolder;

    bool selected = false;

    public void ToggleKeyword()
    {
        if (!selected)
        {
            transform.SetParent(searchBarHolder);
        }
        else
        {
            transform.SetParent(originalParent);
        }

        selected = !selected;
    }
}
