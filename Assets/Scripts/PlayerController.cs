using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20;
    public float xRange = 10f;
    
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        var position = transform.position;
        if (position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, position.y, position.z);
        }

        if (position.x > xRange)
        {
            transform.position = new Vector3(xRange, position.y, position.z);
        }

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // 如果空格键被点击
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}