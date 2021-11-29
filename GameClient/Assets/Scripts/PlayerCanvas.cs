using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCanvas : MonoBehaviour
{

    void Update()
    {
        transform.LookAt(Camera.current.transform);
    }


}
