using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [SerializeField] private GameObject cosaQueQuierSeguir; 

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cosaQueQuierSeguir.transform.position + new Vector3(0, 0, -10);
    }
}
