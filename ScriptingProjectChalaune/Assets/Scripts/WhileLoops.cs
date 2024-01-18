using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    int cupInTheSink = 4;
    // Start is called before the first frame update
    void Start()
    {
        while (cupInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupInTheSink--;
        }
    }
}