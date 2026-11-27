using UnityEngine;
public class ClaseNormal
{
    int numero1;
    int numero2;

    public ClaseNormal(int param1, int param2)
    {
        numero1 = param1;
        numero2 = param2;
    }
    public int SumaEnteros(int a, int b)
    {
        return a + b;
    }
}
public class clases : MonoBehaviour
{
    float campo1;
    bool campo2;
    int campo3=5;
    int campo4=4;


    //summary
    //campos
    //</summary>
    /// <param name="a"> </param>
    /// <param name="b"> </param>
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        campo1 = SumaEnteros(campo3, campo4);
        Debug.Log("el resultado de la suma es: " + campo1);
        VuelveCeroAlNumero(out campo1);
        Debug.Log("el resultado de la funcion vuelve cero es: " + campo1); 
        ClaseNormal claseNormal = new ClaseNormal(campo3, campo4);
        campo1 = claseNormal.SumaEnteros(campo3, campo4);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float SumaEnteros(float a, float b)
    {
        return a + b;
    }
    public int SumaEnteros(int a, int b)
    {
        return a + b;
    }
    public void VuelveCeroAlNumero(out float numero)
    {
        numero = 0;
    }

    public int propiedad1 { get; set; }
    public bool propiedad2 { get; set; }

    public float propiedadsololectura { get; }
}

