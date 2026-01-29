using UnityEngine;

public class player2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f; // Hýzý buradan ayarlayabilirsin
    public SpriteRenderer sprite; // Karakterin görselini buraya sürükle

    void Update()
    {
        // 1. Inputlarý Al (Daha temiz bir yöntem)
        float moveX = Input.GetAxisRaw("Horizontal"); // A:-1, D:1
        float moveY = Input.GetAxisRaw("Vertical");   // S:-1, W:1

        // 2. Hareket Vektörünü Hesapla ve Normalize Et
        // Bu sayede çapraz giderken 0.7071 gibi deðerleri manuel yazmana gerek kalmaz
        Vector2 moveInput = new Vector2(moveX, moveY).normalized;

        // 3. Hýzý Rigidbody'ye Uygula
        rb.linearVelocity = moveInput * moveSpeed;

        // 4. Görseli Döndürme (Rotation yerine Flip)
        // Karakterin rotasyonunu (rotation) deðiþtirmiyoruz, sadece resmini yansýtýyoruz.
        // Bu sayede silahýn baðlý olduðu Transform bozulmuyor.
        if (moveX > 0)
        {
            sprite.flipX = false; // Saða bak
        }
        else if (moveX < 0)
        {
            sprite.flipX = true; // Sola bak
        }
    }
}
