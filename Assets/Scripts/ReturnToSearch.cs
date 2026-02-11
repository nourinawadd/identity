using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToSearch : MonoBehaviour
{
    public string searchSceneName = "Search";

    public void Return()
    {
        Debug.Log("Returning to search scene...");
        SceneManager.LoadScene(searchSceneName);
    }
}
