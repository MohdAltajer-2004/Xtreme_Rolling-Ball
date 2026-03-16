using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float collectableXRotation, collectableYRotation, collectableZRotation;
     ScoreManager scoreManger;
    private void Start()
    {
        scoreManger = FindAnyObjectByType<ScoreManager>();
    }
    private void Update()
    {
        gameObject.transform.Rotate(new Vector3(collectableXRotation, collectableYRotation, collectableZRotation));
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            scoreManger.CollectCollectible();
        }
    }
}

