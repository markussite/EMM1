using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField]private GameObject player;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + ((Quaternion.Slerp(player.transform.rotation, transform.rotation,2))*offset);

        transform.rotation = player.transform.rotation * Quaternion.Euler(20, 0, 0);
    }
}
