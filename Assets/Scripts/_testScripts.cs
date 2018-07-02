using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _testScripts : MonoBehaviour {
    private void Update()
    {
        transform.position = new Vector3(Mathf.Repeat(Time.time, 3), transform.position.y, transform.position.z);
    }
}
