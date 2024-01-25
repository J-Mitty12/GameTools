using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(menuName = "Single Attribute/IntData1")]
public class IntData1 : JulianID
{
    public int value;

    public void AddToValue(int num)
    {
        value += num;
    }

    public void ResetValue(int num)
    {
        value = num;
    }

    public void ReplaceValue(int num)
    {
        value = num;
    }

    public void DisplayImage(Image img)
    {
        img.fillAmount = value;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
    

}