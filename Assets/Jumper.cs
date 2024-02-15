using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody rigid;

    void Start()
    {
        rigid.AddForce(0, 500, 0);
    }
}
