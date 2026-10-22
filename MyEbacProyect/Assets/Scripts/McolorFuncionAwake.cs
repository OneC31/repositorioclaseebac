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
    void Start()
    {  
        var1 = true;
        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        
        if (var1)
        {
            
            GetComponent<MeshRenderer>().material.color = Color.black;
            var1 = false;
        }
        else
        {
             
            GetComponent<MeshRenderer>().material.color = Color.white;
            var1 = true;
        }
        
    }
}
