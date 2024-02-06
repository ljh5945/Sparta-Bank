using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentMoney : MonoBehaviour
{
    [SerializeField] private Text txt_Money; // 현금
    [SerializeField] private Text txt1_Money; // 저축
    [SerializeField] private InputField inputTxT_Money; // 입금 버튼

    private int currentMoney = 100000; // 현금
    private int balanceMoney = 50000;

    public GameObject EndPanel;

    private void Start()
    {
        txt_Money.text = "100000";
        txt1_Money.text = "50000";
    }

    public void Input()
    {
        currentMoney += int.Parse(inputTxT_Money.text);
        balanceMoney -= int.Parse(inputTxT_Money.text);

        txt_Money.text = currentMoney.ToString();
        txt1_Money.text = balanceMoney.ToString();
    }

    public void Output() 
    {
        currentMoney -= int.Parse(inputTxT_Money.text);
        balanceMoney += int.Parse(inputTxT_Money.text);

        txt_Money.text = currentMoney.ToString();
        txt1_Money.text = balanceMoney.ToString();
    }

    private void Update()
    {
        if (currentMoney <= 0)
        {
            EndPanel.gameObject.SetActive(true);
        }
    }
}
