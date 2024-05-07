using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovi : MonoBehaviour
{
    public AudioClip cam;
    private AudioSource pasos;
    private Rigidbody reig;
    public float x, y;
    private bool correr;
    private PlayerInput _plainput;
   
    private Transform _transform;
    public bool nose;
    public bool car;
   
    // Start is called before the first frame update
    private void Awake()
    {
        _transform = transform;
        _plainput = GetComponent<PlayerInput>();
    }
    void Start()
    {
       
        pasos = GetComponent<AudioSource>();
        reig = GetComponent<Rigidbody>();

    }
    private void OnEnable()
    {
        _plainput.actions["Interact"].performed += onon;
       
    }
    private void OnDisable()
    {
        _plainput.actions["Interact"].performed -= onon;
    }
    void onon(InputAction.CallbackContext CallbackContext)
    {
        Debug.Log(message:("interactua"));

    
       /* if (Physics.Raycast(_transform.position + (Vector3.up * 0.3f) + (_transform.forward * 0.2f), _transform.forward
            , out var hit, 1.5f, layerinter)) ;*/

    }
    public bool cc()
    {
        return car;
    }
    // Update is called once per frame
    void Update()
    {
      
       
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (!correr)
            {
                pasos.PlayOneShot(cam);
                correr = true;
            }
           
           
           
        }
        else
        {
            correr = false;
        }

    }
    private void FixedUpdate()
    {
        float yVelocity = reig.velocity.y;



        reig.velocity = new Vector3(x*5, yVelocity, y*5);
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        x = context.ReadValue<Vector3>().x;

        y = context.ReadValue<Vector3>().y;
    }
   
}
