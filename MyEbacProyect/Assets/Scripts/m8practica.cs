using UnityEngine;

public class m8practica : MonoBehaviour
{
    sbyte miByteConSigno = 0;
    byte miByte = 0;
    short miShort = 0;
    ushort miShortSinSigno = 0;
    int miInt = 0;
    uint miIntSinSigno = 0;
    long miLong = 0;
    ulong miLongSinSigno = 0;

    // Start is called before the first frame update
    void Start()
    {
        miByteConSigno = -25;
        miInt = miByteConSigno;
        Debug.Log("el valor de miByteConSigno es: " + miByteConSigno);
        Debug.Log("el valor de miInt es: " + miInt);
        miByte = 200;
        miIntSinSigno = miByte;
        miIntSinSigno = (uint)miByteConSigno;
        Debug.Log("el valor de miIntSinSigno es: " + miIntSinSigno);

        miLong = long.MaxValue;
        miInt = (int)miLong;
        Debug.Log("el valor de miInt es: " + miInt);

        float a,b,c;
        float f;
        a = 5;
        b = 10;
        c = a + b;
        Debug.Log(c);
        c = a * b;
        Debug.Log(c);
        c = a - b;
        Debug.Log(c);
        f = a / b;
        Debug.Log(f);
        miInt = (int)Random.Range(a, b);
        if (miInt % 2 == 0)
        {
            Debug.Log("el numero" + miInt + " es par");
        }
        else
        {
            Debug.Log("el numero" + miInt + " es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
       // miShort += 3;
       // Debug.Log("el valor de miShort es: " + miShort);
       // miLong /= 2;
        //Debug.Log("el valor de miLong es: " + miLong);
        
    }
}
