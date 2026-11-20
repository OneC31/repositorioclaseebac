using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    public string color = "rojo";
    public GameObject CUBO2;
    int A;
    float B = 1;
    float C = 1;
    float D = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //crea 1 variable de tipo entero que incremente su valor en cada frame y el 2do de tipo float que se incremente en cada fixedupdate utilizando 
        //el operador *=
        //ejercicio2
        C *= 1.1f;
        D = 2 * C;
        //resultados de mis flotantes
        int resultado = (int)(C + D);
        Debug.Log("C + D en float: " + (C + D) + " luego decasteado a int: " + resultado);  
        //Debug.Log("el valor de C es: " + C);

        //convertir un numero flotante a string e imprimir 4 posiciones de precision (decimales)
        float nFlotante = 3.14159f;
        string nFlotanteString = nFlotante.ToString("F4");
        Debug.Log("El número flotante con 4 posiciones de precisión: " + nFlotanteString);

        //utilizar el metodo substring 
        // para separar su nombre completo en 3 strings y utilizar el metodo split para separar su nombre completo en una lista de strings
        string nombreCompleto = "Juan Pérez García";
        string primerNombre = nombreCompleto.Substring(0, nombreCompleto.IndexOf(" "));
        string segundoNombre = nombreCompleto.Substring(nombreCompleto.IndexOf(" ") + 1, nombreCompleto.LastIndexOf(" ") - nombreCompleto.IndexOf(" ") - 1);
        string apellido = nombreCompleto.Substring(nombreCompleto.LastIndexOf(" ") + 1);
        Debug.Log("Primer nombre: " + primerNombre);
        Debug.Log("Segundo nombre: " + segundoNombre);
        Debug.Log("Apellido: " + apellido);

        string[] nombres = nombreCompleto.Split(' ');
        Debug.Log("Lista de nombres:");
        foreach (string n in nombres)
        {
            Debug.Log(n);
        }


        //ejercicio7
        string texto1 = "1200";
        string texto2 = "2300";

        int numero1;
        int numero2;

        if (int.TryParse(texto1, out numero1) && int.TryParse(texto2, out numero2))
        {
            int suma = numero1 + numero2;
            Debug.Log("la suma de " + numero1 + " + " + numero2 + " es: " + suma);   // 3800
        }
        else
        {
            Debug.Log("uno de los textos no es un numero valido");
        }

        string oracion = "Hola Mundo";
        string resultados = "";

        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)   // índice par
            {
                resultados += oracion[i] + ",";
            }
        }

        Debug.Log(resultados);

        string oracion2 = "Hola Mundo desde Unity";
        Debug.Log("original: " + oracion2);

        // Opción 1: Substring, toma desde la posición 5 hasta el final
        string conSubstring = oracion2.Substring(5);
        Debug.Log("con Substring: " + conSubstring);
    }

    // Update is called once per frame
    void Update()
    {
        //ejercicio1
        A++;
        //Debug.Log("el valor de A es: " + A);
        
        //utiliza un string y una sentencia switch y dependiendo la palabra el GO cambiara de color, si es rojo sera rojo,
        //si es azul sera azul y si es verde sera verde, si no es ninguno de esos colores sera blanco

        //string color = "azul"; // Cambia este valor para probar diferentes colores

        switch (color)
        {
            case "rojo":
                CUBO2.GetComponent<Renderer>().material.color = Color.red;
                break;
            case "azul":
                CUBO2.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case "verde":
                CUBO2.GetComponent<Renderer>().material.color = Color.green;
                break;
            default:
                CUBO2.GetComponent<Renderer>().material.color = Color.white;
                break;
        }
    }
    void FixedUpdate()
    {
        //ejercicio1
        B *= 1.1f;
        Debug.Log("el valor de B es: " + B);
        //operacion para saber si es par o impar
        if (A % 2 == 0)
        {
            Debug.Log("el numero" + A + " es par");
            GetComponent<Renderer>().material.color = Color.red;
            
        }
        else
        {
            Debug.Log("el numero" + A + " es impar");
            GetComponent<Renderer>().material.color = Color.blue;
        }
        
        

    }
}
