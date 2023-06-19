using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private float MakeTime;
    private float WaitTime;
    [SerializeField] private float EnemyZ;
    [SerializeField] private float EnemyX;
    private float ranX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(WaitTime < MakeTime)
        {
            WaitTime = WaitTime + Time.deltaTime;
        }
        else
        {
            ranX = Random.Range(EnemyX * -1, EnemyX);
            Instantiate(EnemyPrefab, new Vector3(ranX, 0, EnemyZ), EnemyPrefab.transform.rotation);
            WaitTime = 0;
        }
    }
}
