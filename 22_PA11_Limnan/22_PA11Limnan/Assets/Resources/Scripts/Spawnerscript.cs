using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[]SpawnObject;
    private int random;
    private float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        random = Random.Range(0,3);
        Instantiate(SpawnObject[random], transform.position, transform.rotation);
    }
}
