using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalanceMoney : MonoBehaviour
{
    [SerializeField] private Text txt_Money; // ว๖ฑÝ
    [SerializeField] private Text txt1_Money; // ภÜพื
    [SerializeField] private InputField outputTxT_Money;

    private int currentMoney = 100000;
    private int balanceMoney = 50000; // ภÜพื

    public GameObject EndPanel;

    private void Start()
    {
        txt_Money.text = "100000";
        txt1_Money.text = "50000";
    }

    public void Input()
    {
        currentMoney -= int.Parse(outputTxT_Money.text);
        balanceMoney += int.Parse(outputTxT_Money.text);

        txt1_Money.text = balanceMoney.ToString();
        txt_Money.text = currentMoney.ToString();
    }

    public void Output()
    {
        currentMoney += int.Parse(outputTxT_Money.text);
        balanceMoney -= int.Parse(outputTxT_Money.text);

        txt1_Money.text = balanceMoney.ToString();
        txt_Money.text = currentMoney.ToString();
    }

    private void Update()
    {
        if (balanceMoney <= 0)
        {
            EndPanel.gameObject.SetActive(true);
        }
    }
}
