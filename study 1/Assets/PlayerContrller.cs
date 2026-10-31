using UnityEngine;
public class PlayerMove : MonoBehaviour
{
   
    public float speed = 0.1f;
    public GameObject BulletPrefab;   
    public float BulletSpeed;

    void Update()
    {
       
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed, 0);
        }

      
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed, 0);
        }

  
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }

  
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 3; i++) // 3발 발사[cite: 10, 11]
            {
                // 총알 생성 및 위치 설정[cite: 7, 11]
                GameObject Bullet = Instantiate(BulletPrefab);
                Vector3 bulletPos = transform.position;
                bulletPos.y += 0.3f * i; // 총알 간격 미세 조정[cite: 11]
                Bullet.transform.position = bulletPos;

                // 총알에 물리 힘(AddForce)을 주어 위로 발사[cite: 8, 11]
                Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed);
            }
        }
    }
}