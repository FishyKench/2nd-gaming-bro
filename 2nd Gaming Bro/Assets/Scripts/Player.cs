using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController _Ccontrol;

    // Start is called before the first frame update
    void Start()
    {
        _Ccontrol = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
