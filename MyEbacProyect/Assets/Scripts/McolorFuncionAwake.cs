using UnityEngine;

public class McolorFuncionAwake : MonoBehaviour
{
    // Use this for initialization
    void Awake()
    {
     // Cambiar color
        Color c = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = c;
           
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
