using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stun : MonoBehaviour
{
    private float TimeLeft = 1.0f;
    private float nextTime = 0.0f;
    public SPUM_Prefabs _spumPref;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft;
            attack();
        }

    }

    void attack()
    {
        _spumPref.PlayAnimation("3_Debuff_Stun");
        
    }
}
