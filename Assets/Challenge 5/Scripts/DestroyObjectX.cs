using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
          Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
