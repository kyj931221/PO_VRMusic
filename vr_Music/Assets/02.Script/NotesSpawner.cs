using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesSpawner : MonoBehaviour
{
    public GameObject[] notes;
    public Transform[] pos;

    public float time = 1;
    float timer;

    private void Update()
    {
        if(timer > time)
        {
            timer -= time;
            int i = Random.Range(0, pos.Length);
            GameObject note = Instantiate(notes[Random.Range(0, 2)], pos[i]);

            note.transform.localPosition = Vector3.zero;
            i = Random.Range(0, pos.Length);
            note.transform.Rotate(transform.forward, 90 * i);
        }
        timer += Time.deltaTime;
    }
}
