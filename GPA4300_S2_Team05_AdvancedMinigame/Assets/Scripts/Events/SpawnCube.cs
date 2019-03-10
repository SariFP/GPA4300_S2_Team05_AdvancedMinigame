using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject PlayerLeila;
    public GameObject PlayerDan;
    public GameObject SpawnElement;

    [Header("Sounds")]
    [Range(0, 1)]
    public float Volume = 1;
    public AudioClip SpawnSound;

    private void OnCollisionEnter(Collision button)
    {
        if (button.gameObject == PlayerLeila)
        {
            AudioSource.PlayClipAtPoint(SpawnSound, PlayerLeila.transform.position, Volume);
            SpawnElement.SetActive(true);
        }
        else if (button.gameObject == PlayerDan)
        {
            AudioSource.PlayClipAtPoint(SpawnSound, PlayerDan.transform.position, Volume);
            SpawnElement.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
