using UnityEngine;

public class DropdownMenuController : MonoBehaviour
{
    public GameObject dropdownMenu;

    public void ToggleMenu()
    {
        dropdownMenu.SetActive(!dropdownMenu.activeSelf);
    }
}
