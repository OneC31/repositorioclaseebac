using UnityEngine;

public class CubeAwakeM6 : MonoBehaviour
{
    public GameObject CUBOM6;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        // Crear cubo
        GameObject tempGameObject = Instantiate<GameObject>(CUBOM6);
        tempGameObject.name = "Cube";
        
           
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
