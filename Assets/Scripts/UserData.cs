using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UserData", menuName = "NewUserData")]
public class UserData : ScriptableObject
{
    [Header("User Data")]
    public string userName;
    public int Balance;
    public int Cash;
}
