using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float XMax;
    [SerializeField] private float XMin;
    [SerializeField] private float ZMax;
    [SerializeField] private float ZMin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D) && this.transform.position.x < XMax)
        {
            transform.Translate(new Vector3(MoveSpeed, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) && this.transform.position.x > XMin)
        {
            transform.Translate(new Vector3(-MoveSpeed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) && this.transform.position.x < ZMax)
        {
            transform.Translate(new Vector3(0, 0, MoveSpeed) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) && this.transform.position.x > ZMin)
        {
            transform.Translate(new Vector3(0, 0, -MoveSpeed) * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            Debug.Log("Hit");
        }
    }
}
