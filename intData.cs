using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu]
public class intData : ScriptableObject
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
