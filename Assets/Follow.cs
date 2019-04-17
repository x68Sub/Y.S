using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField]private Vector3 offset;
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {

        offset = transform.position - Target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Target.transform.position + offset;
    }
}