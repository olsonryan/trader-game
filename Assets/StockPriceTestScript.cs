using TMPro;
using UnityEngine;

public class StockPriceTestScript : MonoBehaviour
{
    public TMP_Text stockText;
    public float price = 10f;
    public float stockClock = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stockText.text = $"${price:F2}";
    }

    // Update is called once per frame
    void Update()
    {
        stockClock = stockClock + Time.deltaTime;

        if (stockClock > 1)
        {
            price = price + UnityEngine.Random.Range(-0.99f, 0.99f);
            Debug.Log(price);
            stockClock = stockClock - 1;
            stockText.text = $"${price:F2}";
        }
        
    }
}

