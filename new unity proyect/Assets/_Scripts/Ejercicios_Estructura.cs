using System.Collections.Generic;
using UnityEngine;

public class EjerciciosFunciones : MonoBehaviour
{
    void Start()
    {
        // Prueba ejercicio 1
        List<int> numeros = miFuncion(5, 1, 10);
        Debug.Log("Ej1: " + string.Join(", ", numeros));

        // Prueba ejercicio 2
        int[] desordenado = { 4, 9, 1, 7, 3 };
        int[] ordenado = OrdenarDescendente(desordenado);
        Debug.Log("Ej2: " + string.Join(", ", ordenado));   // 9, 7, 4, 3, 1

        // Prueba ejercicio 3
        List<int> conRepetidos = new List<int> { 3, 5, 3, 8, 5, 1 };
        HashSet<int> sinRepetidos = QuitarRepetidos(conRepetidos);
        Debug.Log("Ej3 numeros: " + string.Join(", ", sinRepetidos));   // 3, 5, 8, 1

        List<string> frutas = new List<string> { "mango", "pera", "mango", "uva", "pera" };
        HashSet<string> frutasUnicas = QuitarRepetidos(frutas);
        Debug.Log("Ej3 strings: " + string.Join(", ", frutasUnicas));   // mango, pera, uva
    
         // ---------- Prueba ejercicio 4 (dentro de Start) ----------
        Stack<string> pila = new Stack<string>();
        pila.Push("uno");
        pila.Push("dos");
        pila.Push("tres");
        PilaACola(pila);
}
    // Ejercicio 1: lista de aleatorios
    public List<int> miFuncion(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> lista = new List<int>();
        for (int i = 0; i < tamaño; i++)
        {
            lista.Add(Random.Range(rangoInferior, rangoSuperior + 1));   // +1 para incluir el superior
        }
        return lista;
    }

    // Ejercicio 2: ordenar de mayor a menor
    public int[] OrdenarDescendente(int[] arreglo)
    {
        int[] copia = (int[])arreglo.Clone();   // para no modificar el original
        System.Array.Sort(copia);               // ordena de menor a mayor
        System.Array.Reverse(copia);            // lo voltea: de mayor a menor
        return copia;
    }

    // Ejercicio 3: quitar repetidos usando Contains (sirve para números y strings)
    public HashSet<T> QuitarRepetidos<T>(List<T> lista)
    {
        HashSet<T> resultado = new HashSet<T>();
        foreach (T elemento in lista)
        {
            if (!resultado.Contains(elemento))
            {
                resultado.Add(elemento);
            }
        }
        return resultado;
    }
    // Ejercicio 4: pasar de pila a cola

    public void PilaACola(Stack<string> pila)
{
    Queue<string> cola = new Queue<string>();

    Debug.Log("--- Contenido de la pila ---");
    while (pila.Count > 0)
    {
        string elemento = pila.Peek();   // mira el de arriba sin sacarlo
        Debug.Log(elemento);
        cola.Enqueue(elemento);          // lo copia a la cola
        pila.Pop();                      // ahora sí lo saca de la pila
    }

    Debug.Log("--- Contenido de la cola ---");
    while (cola.Count > 0)
    {
        Debug.Log(cola.Peek());          // mira el primero sin sacarlo
        cola.Dequeue();                  // lo saca de la cola
    }
}
}