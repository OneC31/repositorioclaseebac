using UnityEngine;

public class m7condicionales : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { variable1 = true;
      variable2 = false;
        if (variable1 == false)
        { Debug.Log("false");
        }
        else
        { Debug.Log("true");
        }
        if (valor1 < 5)
        {
            Debug.Log("El valor es menor que 5");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
