using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonsController : MonoBehaviour
{
   public void PlayAgain()
    {
        SearchMemory.Clear(); // reset selected keywords
        SceneManager.LoadScene("Search");
    }
    public void NextCase()
    {
        CaseManager.Instance.LoadNextCase();
        SearchMemory.Clear();
        SceneManager.LoadScene("Search");
    }
}
