using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    public int id;
    public GameObject explosionPrefab;
    public Transform grenadePrefab;

    private Vector3 randRotation;

    private void Awake()
    {
        randRotation = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f));
        //randRotation = new Vector3(Random.Range(-0.5f, 0.5f), 0, 0);
    }
    private void Update()
    {
        grenadePrefab.Rotate(randRotation);
    }
    public void Initialize(int _id)
    {
        id = _id;
    }

    public void Explode(Vector3 _position)
    {
        transform.position = _position;
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        GameManager.projectiles.Remove(id);
        Destroy(gameObject);
    }
}
