// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlatformSpawnerScript : MonoBehaviour
// {
//     public GameObject Platform;
//     // Start is called before the first frame update
//     void Start()
//     {
//         InvokeRepeating("PlatformSpawner", 1, 1);
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
//     void PlatformSpawner()
//     {
//         int x = Random.Range(7, -7);
//         int y = Random.Range(5, 0);
//         Vector2 platformcordinats = new Vector2(x, y);
//         Instantiate(Platform, platformcordinats, Quaternion.identity);
//     }
// }
