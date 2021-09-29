using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public class TestScript : MonoBehaviour
    {
        [SerializeField]
        private ParticleSystem ps;

        void Start()
        {
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                ps.Play();
            if (Input.GetKeyUp(KeyCode.Space))
                ps.Clear();
           // PlayParticle();
        }
 
        public void PlayParticle()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                ps.Play();
            if (Input.GetKeyUp(KeyCode.Space))
                ps.Clear();
        }
    }
}
