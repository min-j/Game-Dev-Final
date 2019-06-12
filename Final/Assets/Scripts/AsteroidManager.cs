using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    [SerializeField] int numberOfAsteroidsOnAnAxis = 10;
    [SerializeField] int gridSpacing = 1000;
    [SerializeField] Asteroid asteroid;

    private void Start()
    {
        //PlaceAsteroids();
    }

    private void OnEnable()
    {
        EventManager.onStartGame += PlaceAsteroids;
    }

    private void OnDisable()
    {
        EventManager.onStartGame -= PlaceAsteroids;
    }

    void PlaceAsteroids() {
        //places asteroids randomly
        for (int x = 0; x < numberOfAsteroidsOnAnAxis; x++)
        {
            for (int y = 0; y < numberOfAsteroidsOnAnAxis; y++)
            {
                for (int z = 0; z < numberOfAsteroidsOnAnAxis; z++)
                {
                    InstantiateAsteroid(x, y, z);
                }
            }
        }
    }

    void InstantiateAsteroid(int x, int y, int z) {
        Instantiate(asteroid, new Vector3(transform.position.x + (x * gridSpacing) + AsteroidOffset(),
                                          transform.position.y + (y * gridSpacing) + AsteroidOffset(), 
                                          transform.position.z + (z * gridSpacing) + AsteroidOffset()), 
            Quaternion.identity, 
            transform);
    }

    float AsteroidOffset() {
        return Random.Range(-gridSpacing/2f, gridSpacing/2f);
    }
}
