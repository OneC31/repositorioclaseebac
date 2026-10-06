using UnityEngine;

public class Componente1 : MonoBehaviour
{
    public static GameObject Miobjeto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        
    }
    void Start()
    {
        Miobjeto = this.gameObject;
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
