using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CemberKontrol : MonoBehaviour
{
    public bool solaDonme = true;
    public float donmeHizi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (solaDonme)
        {  
            transform.Rotate(0f, 0f, donmeHizi * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0f, 0f, -donmeHizi * Time.deltaTime);
        }
        
    }
    
}
