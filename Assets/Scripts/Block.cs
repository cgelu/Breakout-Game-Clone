using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int hits = 1;
    public int points = 100;
    public Vector3 rotator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        hits--;
        if(hits <= 0)
        {
            GameManager.Instance.Score += points;
            Destroy(gameObject);
        }
    }
}
