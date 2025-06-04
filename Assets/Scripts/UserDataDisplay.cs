using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserDataDisplay : MonoBehaviour
{
    public UserData userData;
    public TMP_Text userNameText;
    public TMP_Text balanceText;
    public TMP_Text cashText;

    void Start()
    {
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        userNameText.text = userData.userName;
        balanceText.text = "Balance: " + userData.Balance.ToString();
        cashText.text = "현금\n" + userData.Cash.ToString();
    }
}

