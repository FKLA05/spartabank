using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public UserData userData;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            
            LoadUserData();
            
            if (userData == null)
                userData = new UserData("김재훈", 100000, 50000);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SaveUserData()
    {
        string json = JsonUtility.ToJson(userData);
        PlayerPrefs.SetString("UserData", json);
        PlayerPrefs.Save();
    }
    
    public void LoadUserData()
    {
        if (PlayerPrefs.HasKey("UserData"))
        {
            string json = PlayerPrefs.GetString("UserData");
            userData = JsonUtility.FromJson<UserData>(json);
        }
    }
}
