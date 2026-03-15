using System.Collections;
using UnityEngine;

public class HasuMUsaScript : MonoBehaviour
{

    public float waitTime;
    private AudioSource AS;
    bool again = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (again)
        {
            StartCoroutine(cahngepitCH());
        }
    }

    IEnumerator cahngepitCH()
    {
        again = false;
        AS.pitch = Random.Range(0.3f, 1.5f);
        yield return new WaitForSeconds(waitTime);
        again = true;
    }
}
