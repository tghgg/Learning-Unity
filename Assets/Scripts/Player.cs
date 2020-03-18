using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// You can safely ignore what's above (at least imo)

// Follow the C# coding convetion
// Properties, public methods: PascalCase
// Local variables, function parameters: camelCase

// So basically one line should only contain one thing
// Also this monstrosity:
// if (stuff)
// {
// }

// Namespaces are basically a collection of classes that can be accessed
// eg. namespace Enemy {
//   public class Controller: MonoBehavior {}
// }
// Access Controller with Enemy.Controller
// or if you have 'using Enemy' it's just Controller
// Think back of C++

// Basically Godot class_name ClassNameHereNibba extends MonoBehaviour
// MonoBehavior is like the base Node class in Godot
public class Player : MonoBehaviour
{    
    // You can get all children with their Transform component since
    // all GameObjects have Transform.
    // Transform also feel like a part of a Godot Node class since it handles meta things
    // about the GameObject.
    
    // GameObject.Find("Name") is basically get_node("node_path")
    // You can also search GameObjects by their tags.
    // GameObject.FindWithTag() or GameObject.FindGameObjectsWithTag()
    
    public float move_speed = 150.0f;
    // var is used for implicitly typing things; only for local variables declaration
    // public var ImplicitThing = 150;
    // Else just do the normal type typed_var thing
    
    // Declare arrays like this
    public string[] arrayOfStrings = {"helu", "nibba"};
    
    // Try-Catch also exists it seems
    
    private Transform tf;
    private Rigidbody2D body;
    
    // You can create new GameObjects from code with Instantiate
    // Remove GameObjects with Destroy which sends a terminate signal to the object 
    // You can also only destroy a component of a GameObject through Destroy, so keep that in mind
    
    // Hey, Unity also uses yield for coroutines
    // so that's really nice. Well not
    // You have to declare coroutines, so it's not like you can just sprinkle in a yield like in Godot
    IEnumerator Fade()
    {
        // Do stuff
        yield return null;
    }
    // To run a coroutine, use StartCoroutine(coroutine)
    // eg. StartCoroutine("Fade");
    // Stop coroutine with StopCoroutine("Fade");
    
    // You can use coroutines in place of just putting functions in Update as Update can
    // run several times a second. This reduces overhead as coroutines can loop whenever you want it to.
    
    // Start is called before the first frame update
    // Godot's _ready()
    // On the other hand Godot's _init() is Unity's Awake()
    // The flow is Awake -> Start
    void Start()
    {
        // The <Transform> part I still don't get. Just a static typed language thing
        // Cast variables with (new_type)var;
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
        
        // Wrap your comparisons up
        if ((horizontal_input == 0) && (vertical_input == 0))
        {
            Debug.Log("Stopping...");
        } 
        else 
        {
             body.AddForce(new Vector2(horizontal_input, vertical_input) * move_speed * Time.deltaTime);
        }
    }
    
    // Public functions, variables can be edited in the editor, just like Godot's exported variables
    public void DestroyAllNibbas() {
        Debug.Log("All Nibbas destroyed");
    }
}
