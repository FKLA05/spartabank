using System.Collections;
using System.Collections.Generic;
using System;

[Serializable] 
public class UserData
{
    public string name;
    public int cash;
    public int balance;
    
    public UserData(string name, int cash, int balance)
    {
        this.name = name;
        this.cash = cash;
        this.balance = balance;
    }

    public void Deposit(int amount)
    {
        if (cash >= amount)
        {
            balance += amount;
            cash -= amount;
            GameManager.Instance.SaveUserData();
        }
        else
        {
            
        }
    }

    public void Withdraw(int amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            cash += amount;
            GameManager.Instance.SaveUserData();
        }
        else
        {
            
        }
        
    }
}
