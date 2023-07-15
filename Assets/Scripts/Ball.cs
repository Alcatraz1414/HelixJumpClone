using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;

    public GameObject splashPrefab;

    private GameManager gameManager;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up*jumpForce);
        GameObject splash = Instantiate(splashPrefab,transform.position+new Vector3(0f,-0.24f,0f),transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName= collision.gameObject.GetComponent<MeshRenderer>().material.name;
        
        if (materialName== "UnsafeColor (Instance)") //buraya (Instance) yazmamýzýn sebebi name in yanýna bunu oto ekliyor
        {
            gameManager.RestartGame();
        }
        else if (materialName == "LastRing (Instance)")
        {
            print("NEXT LEVEL");
        }
    }
}
