using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectible : MonoBehaviour
{ 
    
    [SerializeField] public Transform collectible;

    [SerializeField] public Transform collectibleParent;
    // Start is called before the first frame update
    void Start()
    {
        
        int x;
        int y;
        for (int i = 0; i < 10; i++)
        {
            x = UnityEngine.Random.Range(1,10);
            y = UnityEngine.Random.Range(1,10);
            Instantiate(collectible, new Vector3(0+y,  3.5f, 0+x), Quaternion.identity, collectibleParent);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
