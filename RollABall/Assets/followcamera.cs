using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcamera : MonoBehaviour
{
    public Transform playerTransfrom;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerTransfrom.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransfrom.position + offset;

        
    }
}
