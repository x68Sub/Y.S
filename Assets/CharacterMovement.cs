using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]private float j;
    private float h;
    private float v;
    public float WalkSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical") * WalkSpeed;
        h = Input.GetAxis("Horizontal") * WalkSpeed;
        this.gameObject.transform.Translate(h, j, v);
        if (Input.GetButtonDown("Jump"))
        {
            j = 1;
            AboutJump();
        }
        if (Input.GetButtonUp("Jump")) {
            j = 0;
        }
    }

    void AboutJump()
    {
        float TIme = 5.0f;
        TIme -= Time.deltaTime;
        if ()
    }
}
