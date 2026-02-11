using UnityEngine;
using UnityEngine.EventSystems;

public class DropdownMenu : MonoBehaviour
{
    public GameObject dropdownMenu;

    public void ToggleMenu()
    {
        bool isActive = dropdownMenu.activeSelf;
        dropdownMenu.SetActive(!isActive);

        if (isActive)
            ResetSelection();
    }

    public void CloseMenu()
    {
        dropdownMenu.SetActive(false);
        ResetSelection();
    }

    void ResetSelection()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }
}
