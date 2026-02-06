using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] dogPrefabs;
    void Update()
    {
        //int n = 0;
        //for (int i = 0; i < dogPrefabs.Length; ++i) 
        //{
        //    Instantiate(dogPrefabs[i], new Vector3(0,0,20), Quaternion.Euler(0,180,0));
        //}

        //while(n < dogPrefabs.Length)
        //{
        //    Debug.Log(n);
        //    Instantiate(dogPrefabs[n], new Vector3(0, 0, 20), Quaternion.Euler(0, 180, 0));

        //    n++;
        //}

        float x = Random.Range(-10, 10);

        int index = Random.Range(0, dogPrefabs.Length);

        if (Input.GetKeyDown(KeyCode.S))
        {
            
            Instantiate(dogPrefabs[index], new Vector3(x, 0, 20), Quaternion.Euler(0, 180, 0));
        }

        else { Debug.LogWarning($"dog prefab {index} is null"); }

    }
}
