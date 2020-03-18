using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// You can safely ignore what's above (at least imo)

// Basically Godot class_name ClassNameHereNibba extends MonoBehaviour
public class Player : MonoBehaviour
{    
    
    public float move_speed = 150.0f;
    
    private Transform tf;
    private Rigidbody2D body;
    
    // Start is called before the first frame update
    // Godot's _ready()
    void Start()
    {
        // The <Transform> part I still don't get. Just a static typed language thing
        tf = GetComponent<Transform>();
        body = GetComponent<Rigidbody2D>();
        Debug.Log("Helu worl");
        Debug.Log(tf);
    }

    // Godot's process
    // physics_process is FixedUpdate
    // Update is called once per frame
    void FixedUpdate()
    {
        
        // Get the value (-1.0 to 1.0) of these input
        float horizontal_input = Input.GetAxis("Horizontal");
        
        float vertical_input = Input.GetAxis("Vertical");
        
        // Transform.Translate moves the GameObject without applying physics
        // So basically just like blindly adding to the position property in Godot
        //.Translate(new Vector3(horizontal_input, vertical_input, 0) * move_speed * Time.deltaTime);
        // Rigidbody2D.AddForce(vec2) is actually the move_and_slide of Unity. The bread and butter movement engine.
        // Also functions and variables naming follow CamelCase
        body.AddForce(new Vector2(horizontal_input, vertical_input) * move_speed * Time.deltaTime);
    }
    
    // Public functions, variables can be edited in the editor, just like Godot's exported variables
    public void DestroyAllNibbas() {
        Debug.Log("All Nibbas destroyed");
    }
}
