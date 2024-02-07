using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserData
{
    public string Name;
    public int Balance;
    public int Cash;

    public UserData(string name, int balance, int cash)
    {
        Update();
        Name = name;
        Balance = balance;
        Cash = cash;
    }

    public bool Deposit(int money)
    {
        if (Cash < money)
            return false;

        Cash -= money;
        Balance += money;

        return true;
    }

    public bool Withdraw(int money)
    {
        if (Balance < money) return false;

        Cash += money;
        Balance -= money;

        return true;
    }

    private void Update() // 3ÀÚ¸® ½°Ç¥
    {
        String str1 = String.Format("{0:N0}", Balance);
        Console.WriteLine(str1);

        String str2 = String.Format("{0:N0}", Cash);
        Console.WriteLine(str2);
    }
}
