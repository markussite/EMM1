using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float angle;
    [SerializeField] private float movementSpeed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        angle += moveHorizontal*0.01f;
        
        Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0f, Mathf.Cos(angle));

        transform.rotation = Quaternion.LookRotation(targetDirection);
        
        transform.position += moveVertical * movementSpeed * transform.forward;
        
        
    } 
    
    
}
