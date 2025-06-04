using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button depositButton;
    public Button withdrawalButton;

    void Start()
    {
        depositButton.onClick.AddListener(OnDepositClicked);
        withdrawalButton.onClick.AddListener(OnWithdrawalClicked);
    }

    void OnDepositClicked()
    {
        Debug.Log("입금버튼");
    }

    void OnWithdrawalClicked()
    {
        Debug.Log("출금버튼");
    }
    
}
