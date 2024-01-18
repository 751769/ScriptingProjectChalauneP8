using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimmitTemperature = 40.0f;

    // Start is called before the first frame update


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temmperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ...do this.
            print("coffee is too hot.");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimmitTemperature)
        {
            // ... do this.
            print("coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ...do this.
            print("coffee is just right.");
        }
    }
}