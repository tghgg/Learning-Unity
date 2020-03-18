using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    
    public SpriteRenderer TalkBubble;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // All GameObject have these events (which are basically Godot signals) 
    // No need to connect them, just override them like below with what you want to do
    
    // Event which happens when a Collider2D enters this NPC's trigger collider.
    void OnTriggerEnter2D(Collider2D collider) {
            Debug.Log("Thou be" + collider.name);
            Debug.Log("Thou hast entered thy personal void of existence!? Thou shalt pays.");
            TalkBubble.color = new Color(TalkBubble.color.r, TalkBubble.color.g, TalkBubble.color.b, 255.0f);
    }
    
    void OnTriggerExit2D(Collider2D collider) {
        Debug.Log("Thou exits thee: " + collider.name);
        TalkBubble.color = new Color(TalkBubble.color.r, TalkBubble.color.g, TalkBubble.color.b, 0.0f);
    }
}
