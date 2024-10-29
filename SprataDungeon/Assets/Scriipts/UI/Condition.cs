using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Condition : MonoBehaviour
{
    public float curValue;
    public float startValue;
    public float maxVlaue;
    public float passiveValue;
    public Image uiBar;

    private void Start()
    {
        curValue = startValue;
    }

    private void Update()
    {
        uiBar.fillAmount = GetPercentage();
    }
    float GetPercentage()
    {
        return curValue / maxVlaue;
    }

    public void Add(float value)
    {
        curValue += Mathf.Min(curValue + value, maxVlaue);
    }

    public void Subtract(float value)
    {
        curValue -= Mathf.Min(curValue - value, 0);
    }
}
