using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosiiton;

    // Update is called once per frame
    private void Update()
    {
        transform.position = cameraPosiiton.position;
    }
}
