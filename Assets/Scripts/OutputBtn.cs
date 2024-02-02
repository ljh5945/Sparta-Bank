using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutBtn : MonoBehaviour
{
    [SerializeField] private Text txt_Money;
    [SerializeField] private InputField outputTxt_Money;

    private int currentMoney;

    public void output()
    {
        currentMoney += int.Parse(outputTxt_Money.text);

        txt_Money.text = currentMoney.ToString();
    }
}
