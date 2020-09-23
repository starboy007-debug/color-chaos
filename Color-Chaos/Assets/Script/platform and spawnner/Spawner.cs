using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bplatformPrefab;
    public GameObject pplatformPrefab;
    public GameObject rplatformPrefab;
    public GameObject prplatformPrefab;
    public GameObject gplatformPrefab;
    


    public float platform_Spawn_Timer = 1.8f;
    private float current_Platform_Spawn_Timer;

    private int platform_Spawn_Count;

    public float min_X = -2f, max_X = 2f;

    // Start is called before the first frame update
    void Start()
    {
        current_Platform_Spawn_Timer = platform_Spawn_Timer;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPlatforms();
    }

    void SpawnPlatforms()
    {

        current_Platform_Spawn_Timer += Time.deltaTime;

        if (current_Platform_Spawn_Timer >= platform_Spawn_Timer)
        {

            platform_Spawn_Count++;

            Vector3 temp = transform.position;
            temp.x = Random.Range(min_X, max_X);

            GameObject newPlatform = null;

            if (platform_Spawn_Count < 2)
            {

                newPlatform = Instantiate(bplatformPrefab, temp, Quaternion.identity);

            }
            else if (platform_Spawn_Count == 2)
            {

                if (Random.Range(0, 2) > 0)
                {

                    newPlatform = Instantiate(bplatformPrefab, temp, Quaternion.identity);

                }
                else
                {

                    newPlatform = Instantiate(rplatformPrefab,temp, Quaternion.identity);

                }

            }
            else if (platform_Spawn_Count == 3)
            {

                if (Random.Range(0, 2) > 0)
                {

                    newPlatform = Instantiate(bplatformPrefab, temp, Quaternion.identity);

                }
                else
                {

                    newPlatform = Instantiate(prplatformPrefab, temp, Quaternion.identity);

                }

            }
            else if (platform_Spawn_Count == 4)
            {

                if (Random.Range(0, 2) > 0)
                {

                    newPlatform = Instantiate(bplatformPrefab, temp, Quaternion.identity);

                }
                else
                {

                    newPlatform = Instantiate(gplatformPrefab, temp, Quaternion.identity);

                }

                platform_Spawn_Count = 0;

            }

            if (newPlatform)
                newPlatform.transform.parent = transform;

            current_Platform_Spawn_Timer = 0f;

        } // spawn platform

    }
}
