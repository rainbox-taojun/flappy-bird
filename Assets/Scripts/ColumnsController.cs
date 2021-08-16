using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnsController : MonoBehaviour
{
    public GameObject colunmPrefab;
    public int colunmMax = 5;
    public float spawnRate = 3f;
    public float yMin = 1f;
    public float yMax = 5.5f;
    public float xPos = 10f;

    float timeSinceLastSpawned;

    GameObject[] colunms;
    int currentColunm = 0;

    Vector2 originalPos = new Vector2(-10, -20);

    // Start is called before the first frame update
    void Start()
    {
        colunms = new GameObject[colunmMax];

        for (int i = 0; i < colunmMax ;i++)
        {
            colunms[i] = Instantiate(colunmPrefab, originalPos, Quaternion.identity);
		}
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameMode.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
		{
            timeSinceLastSpawned = 0f;

            float yPos = Random.Range(yMin, yMax);
            colunms[currentColunm].transform.position = new Vector2(xPos, yPos);
            currentColunm++;

            if (currentColunm >= colunmMax)
			{
                currentColunm = 0;

            }
		}
    }
}
