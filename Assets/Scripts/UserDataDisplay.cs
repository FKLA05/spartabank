using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserDataDisplay : MonoBehaviour
{
   
    public TMP_Text userNameText;
    public TMP_Text balanceText;
    public TMP_Text cashText;
    
    private void Update()
    {
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        UserData userData = GameManager.Instance.userData;
        userNameText.text = userData.name;
        balanceText.text = "Balance: " + userData.balance.ToString();
        cashText.text = "현금\n" + userData.cash.ToString();
    }
}

