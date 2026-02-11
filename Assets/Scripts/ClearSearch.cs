using UnityEngine;

public class ClearSearch : MonoBehaviour
{
    public Transform searchHolder;

    public void ClearKeywords()
    {
        foreach (Transform keyword in searchHolder)
        {
            KeywordButton btn = keyword.GetComponent<KeywordButton>();

            if (btn != null)
            {
                keyword.SetParent(btn.originalParent);
                btn.ResetKeyword();
            }
        }
    }
}
