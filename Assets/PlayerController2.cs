using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*Input.GetAxis("Horizontal"));
        cc.SimpleMove(transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * 360.0f);
    }
}
