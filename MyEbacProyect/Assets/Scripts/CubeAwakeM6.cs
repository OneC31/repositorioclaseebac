using UnityEngine;

public class CubeAwakeM6 : MonoBehaviour
{

    public GameObject CUBOTE2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {

        // Crear cubo

        GameObject tempGameObject = Instantiate<GameObject>(CUBOTE2);       
        tempGameObject.name = "Cubeclone";
        tempGameObject.transform.position = transform.position; 
        tempGameObject.transform.rotation = transform.rotation;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
