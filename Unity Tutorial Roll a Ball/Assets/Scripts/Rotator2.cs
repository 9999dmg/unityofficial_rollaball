using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator2 : MonoBehaviour {

    private void Update()
    {
        transform.Rotate(new Vector3 (0, 300, 0) * Time.deltaTime);
    }

}
