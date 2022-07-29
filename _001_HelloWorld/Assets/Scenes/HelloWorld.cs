using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    int second = 0;
    bool allow = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        while (allow)
        {
            second++;
            if((second % 2) == 0)
            {
                Debug.Log($"Hello number {second}");
            }
            if (second == 300)
            {
                allow = false;
            }
        }
    }
}
