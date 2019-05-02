using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    public GameObject obstacle;
    public ParticleSystem obstacleParticles;

    // Start is called before the first frame update
    void Start()
    {
        obstacle = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
            obstacleParticles.Play();
        
    }

    private void OnTriggerExit(Collider other)
    {
            obstacleParticles.Stop();
    }
}
