using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Event which happens when a Collider2D enters this NPC's trigger collider
    void OnTriggerEnter2D(Collider2D collider) {
            Debug.Log("Thou be" + collider.name);
            Debug.Log("Thou hast entered thy personal void of existence!? Thou shalt pays.");
    }
}
