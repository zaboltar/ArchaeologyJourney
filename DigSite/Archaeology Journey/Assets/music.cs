using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{

    static public music audioMngr;

    // Start is called before the first frame update
    void Awake()
    {
        // se refiere a la instancia creada de audiomanager

        if (audioMngr == null) {
             audioMngr = this;
             DontDestroyOnLoad(transform.gameObject);
         } else {
             Destroy(gameObject);    
         }
    }
}
