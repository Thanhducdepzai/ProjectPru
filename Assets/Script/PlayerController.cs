using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public float speed = 5.0f;
    public HealthBar healthBar;
    private Vector3 movement;
    public Animator animator;
    float horizontalMove = 0f;
    void Start()
    {
        currentHealth = maxHealth;

    }
 
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")*speed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TakeDamage(20);
        }

        // Lấy thông tin từ các phím mũi tên
        float moveHorizontal = 0f;
        float moveVertical = 0f;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveVertical = 1f; // Đi lên
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            moveVertical = -1f; // Đi xuống
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveHorizontal = -1f; // Sang trái
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            moveHorizontal = 1f; // Sang phải
        }

        // Tạo vector di chuyển dựa trên thông tin từ các phím mũi tên
        movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        

        // Đảm bảo di chuyển theo hướng phù hợp
        if (movement != Vector3.zero)
        {
            movement.Normalize(); // Chuẩn hóa vector di chuyển để không di chuyển nhanh hơn khi đi chéo
        }

        // Di chuyển nhân vật
        transform.position += movement * speed * Time.deltaTime;

        // Xoay nhân vật theo hướng di chuyển
        if (moveHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0); // Quay đầu sang trái
        }
        else if (moveHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0); // Quay đầu sang phải
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
        
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth); // Cập nhật thanh máu
    }
    private void Attack() { 
        // Play an attack animation
        // Detect enemies in range of attack
        // Damage them
    }
}

