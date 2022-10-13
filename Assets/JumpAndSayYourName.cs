using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Models;
using Unity.VisualScripting;
using UnityEngine;

public class JumpAndSayYourName : MonoBehaviour
{
    // Start is called before the first frame update
     public MyModel me;
     public GameObject child;
     private List<Color> colors = new List<Color>() { Color.white,Color.black, Color.blue,Color.cyan ,Color.yellow, Color.magenta, Color.grey, Color.green };
     private int count = 0;
    void Start()
    {
        count = me.JumpTime;
        StartCoroutine(JumpAndSayHello());
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void ChangeColor()
    {
        
    }
    
    public IEnumerator JumpAndSayHello(){
        
        yield return new WaitForSeconds(2);
        child.GetComponent<MeshRenderer>().material.color = colors[count-1];
        print(me.Name);
        count--;
        if (count>0)
        {
            StartCoroutine(JumpAndSayHello());
        }

    }
    
    
    
}
