using UnityEngine;


public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed = 10f;


    void Start()
    {

    }

    void Update()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");


        Vector3 direction = new Vector3(x, y, 0);
        transform.position += direction.normalized * speed * Time.deltaTime;
    }
}