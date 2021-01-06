using UnityEngine;

public class SubmitButton : MonoBehaviour
{

    public TMPro.TMP_Dropdown DropdownMenu;
    public TMPro.TMP_Text CountryRef;
    public void Submit()
    {
        CountryRef.text = DropdownMenu.options[DropdownMenu.value].text;
    }
}