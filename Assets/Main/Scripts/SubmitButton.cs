using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitButton : MonoBehaviour
{
    PlayerData playerData = new PlayerData();
    public void SetGender(string gender)
    {
        playerData.Gender = gender;
    }
    public void SetName(string name)
    {
        playerData.Name = name;
    }
    public void SetCountry(string country)
    {
        playerData.Country = country;
    }
    public void Submit()
    {
        
    }
}

class PlayerData
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public string  Country { get; set; }
}