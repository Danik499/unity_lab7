using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOff : MonoBehaviour
{
    public ParticleSystem ps;
    void Start()
    {
        ps.enableEmission = false;
        StartCoroutine("OffOn");
    }

    void Update()
    {
        
    }

    IEnumerator OffOn ()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            ps.enableEmission = true;
            yield return new WaitForSeconds(0.2f);
            ps.enableEmission = false;
        }
    }
}
