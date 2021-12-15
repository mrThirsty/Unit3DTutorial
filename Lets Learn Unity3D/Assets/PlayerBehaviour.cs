using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float maxDistanceToMove = speed * Time.deltaTime;
        
        Vector3 inputVector = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        Vector3 movementVector = inputVector * maxDistanceToMove;
        Vector3 position = transform.position + movementVector;

        transform.LookAt(position);
        transform.position = position;
        
        if(Input.GetButton("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
