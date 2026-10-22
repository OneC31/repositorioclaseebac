using UnityEngine;

public class McolorFuncionAwake : MonoBehaviour
{
   public bool var1;
   public bool var2;
   public bool var3;

    // Use this for initialization
    void Awake()
    {
     // Cambiar color
       // Color c = new Color(Random.value, Random.value, Random.value);
        //GetComponent<MeshRenderer>().material.color = c;
           
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {  //variable boolean que se modifique cada fix update
        var1 = true;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        
        if (var1 == true)
        {
            var1 = false;
            GetComponent<MeshRenderer>().material.color = Color.white;
            
        }
        else
        {
            var1 = true;
            GetComponent<MeshRenderer>().material.color = Color.black;
            
        }
        
    }
}
