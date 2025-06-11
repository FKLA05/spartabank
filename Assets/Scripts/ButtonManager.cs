using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public InputManager inputManager;
    
    public GameObject mainMenu;
    public GameObject depositMenu;
    
    public GameObject withdrawalMenu;
    
    public Button depositButton;
    public Button withdrawalButton;
    
    public Button depositBackButton;
    public Button depositCustomButton;
    public Button deposit50000Button;
    public Button deposit30000Button;
    public Button deposit10000Button;
    
    public Button withdrawalBackButton;
    public Button withdrawalCustomButton;
    public Button withdrawal50000Button;
    public Button withdrawal30000Button;
    public Button withdrawal10000Button;

    void Start()
    {
        depositButton.onClick.AddListener(OnDepositClicked);
        depositBackButton.onClick.AddListener(OnDepositBackClicked);
        depositCustomButton.onClick.AddListener(OnDespositCustomClicked);
        deposit50000Button.onClick.AddListener(OnDesposit50000Clicked);
        deposit30000Button.onClick.AddListener(OnDesposit30000Clicked);
        deposit10000Button.onClick.AddListener(OnDesposit10000Clicked);

        withdrawalButton.onClick.AddListener(OnWithdrawalClicked);
        withdrawalBackButton.onClick.AddListener(OnWithdrawalBackClicked);
        withdrawalCustomButton.onClick.AddListener(OnWithdrawalCustomClicked);
        withdrawal50000Button.onClick.AddListener(OnWithdrawal50000Clicked);
        withdrawal30000Button.onClick.AddListener(OnWithdrawal30000Clicked);
        withdrawal10000Button.onClick.AddListener(OnWithdrawal10000Clicked);
    }

    void OnDepositClicked()
    { ;
        mainMenu.SetActive(false);
        depositMenu.SetActive(true);
    }

    void OnDepositBackClicked()
    {
        mainMenu.SetActive(true);
        depositMenu.SetActive(false);
    }

    void OnDespositCustomClicked()
    {
        inputManager.CheckNumber();
        OnDepositAmountClicked(inputManager.custom1);
    }
    
    void OnDesposit50000Clicked()
    {
        OnDepositAmountClicked(50000);
    }
    
    void OnDesposit30000Clicked()
    {
        OnDepositAmountClicked(30000);
    }
    
    void OnDesposit10000Clicked()
    {
        OnDepositAmountClicked(10000);
    }
    
    void OnWithdrawalClicked()
    {
        mainMenu.SetActive(false);
        withdrawalMenu.SetActive(true);
    }

    void OnWithdrawalBackClicked()
    {
        mainMenu.SetActive(true);
        withdrawalMenu.SetActive(false);
    }

    void OnWithdrawalCustomClicked()
    {
        inputManager.CheckNumber();
        OnWithdrawalAmountClicked(inputManager.custom2);
    }
    
    void OnWithdrawal50000Clicked()
    {
        OnWithdrawalAmountClicked(50000);
    }
    
    void OnWithdrawal30000Clicked()
    {
        OnWithdrawalAmountClicked(30000);
    }
    
    void OnWithdrawal10000Clicked()
    {
        OnWithdrawalAmountClicked(10000);
    }
    
    void OnDepositAmountClicked(int amount)
    {
        GameManager.Instance.userData.Deposit(amount);
    }
    
    void OnWithdrawalAmountClicked(int amount)
    {
        GameManager.Instance.userData.Withdraw(amount);
    }

}
