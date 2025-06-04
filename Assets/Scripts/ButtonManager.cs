using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject depositMenu;
    //public GameObject depositBack;
    //public GameObject depositCustom;
    //public GameObject deposit50000;
    //public GameObject deposit30000;
    //public GameObject deposit10000;
    
    public GameObject withdrawalMenu;
    //public GameObject withdrawalBack;
    //public GameObject withdrawalCustom;
    //GameObject withdrawal50000;
    //public GameObject withdrawal30000;
    //public GameObject withdrawal10000;
        
    
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
    {
        Debug.Log("입금버튼");
        mainMenu.SetActive(false);
        depositMenu.SetActive(true);
    }

    void OnDepositBackClicked()
    {
        Debug.Log("뒤로가기");
        mainMenu.SetActive(true);
        depositMenu.SetActive(false);
    }

    void OnDespositCustomClicked()
    {
        
    }
    
    void OnDesposit50000Clicked()
    {
        
    }
    
    void OnDesposit30000Clicked()
    {
        
    }
    
    void OnDesposit10000Clicked()
    {
        
    }
    
    void OnWithdrawalClicked()
    {
        Debug.Log("출금버튼");
        mainMenu.SetActive(false);
        withdrawalMenu.SetActive(true);
    }

    void OnWithdrawalBackClicked()
    {
        Debug.Log("뒤로가기");
        mainMenu.SetActive(true);
        withdrawalMenu.SetActive(false);
    }

    void OnWithdrawalCustomClicked()
    {
        
    }
    
    void OnWithdrawal50000Clicked()
    {
        
    }
    
    void OnWithdrawal30000Clicked()
    {
        
    }
    
    void OnWithdrawal10000Clicked()
    {
        
    }
    

}
