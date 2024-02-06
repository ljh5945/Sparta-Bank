using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputBtn : MonoBehaviour
{
    public Text ScriptTxt;
    public Text ScriptTxT;
    public GameObject EndPanel;

    int Balance = 50000;
    int Current = 100000;

    private void Start()
    {
        ScriptTxt.text = "50,000";
        ScriptTxT.text = "100,000";
    }

    public void MoneyPlus1()
    {
        Balance += 10000;
        Current -= 10000;

        ScriptTxt.text = Balance.ToString();
        ScriptTxT.text = Current.ToString();
    }

    public void MoneyPlus2()
    {
        Balance += 30000;
        Current -= 30000;

        ScriptTxt.text = Balance.ToString();
        ScriptTxT.text = Current.ToString();
    }

    public void MoneyPlus3()
    {
        Balance += 50000;
        Current -= 50000;

        ScriptTxt.text = Balance.ToString();
        ScriptTxT.text = Current.ToString();
    }

    private void Update()
    {
        if (Current <= 0)
        {
            EndPanel.gameObject.SetActive(true);
        }
    }
}
