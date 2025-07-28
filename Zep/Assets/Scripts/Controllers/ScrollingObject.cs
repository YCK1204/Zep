using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField]
    [Range(0f, 20f)]
    public float moveSpeed;

    [HideInInspector]
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        // 컴포넌트 참조
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        MoveLeft();
    }

    void MoveLeft()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }

    // Border 태그의 Collider와 충돌했을 때 (카메라 경계를 벗어남)
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Border"))
        {
            BirdGameManager birdGameManager = Manager.Game as BirdGameManager;
            birdGameManager.Spawner.UpdatePosition(gameObject);
        }
    }
}