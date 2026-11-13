using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;          // 이동 속도 (Time.deltaTime 적용 기준 5 정도가 적당)
    public GameObject BulletPrefab;   
    public float BulletSpeed = 500f;  // 총알 발사 힘

    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        
        // 2. 발사 (스페이스바를 누를 때마다 1발 발사)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity);
            Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed);
        }
    }
}