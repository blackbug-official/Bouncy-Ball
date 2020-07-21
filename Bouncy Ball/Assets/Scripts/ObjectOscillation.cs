using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[DisallowMultipleComponent]
public class ObjectOscillation : MonoBehaviour
{
    [SerializeField] Vector3 movemnetVector = new Vector3(15f, 0, 0);
    float movementFactor;

    [SerializeField] float period = 4f; // time for 1 cycle (4 secs)

    Vector3 startingpos;

    // Start is called before the first frame update
    void Start()
    {
        startingpos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (period <= Mathf.Epsilon) { return; } // to protect against value of period getting to 0 , mathf.epsilon represents the smallest possible value
        float cycles = Time.time / period;

        const float tau = Mathf.PI * 2;
        float rawSineWave = Mathf.Sin(cycles * tau);

        movementFactor = rawSineWave / 2f + 0.5f;

        Vector3 offset = movemnetVector * movementFactor;
        transform.position = startingpos + offset;
    }
}
