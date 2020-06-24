using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpSpeed;
    public float playerSpeed;
    private Rigidbody2D _rigidbody2D;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool _isOnPlatform;
    private Animator _animator;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer spriteRenderer1;
    public SpriteRenderer spriteRenderer2;
    public SpriteRenderer spriteRenderer3;

   private static readonly int isOnGround = Animator.StringToHash("isOnGround");
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _isOnPlatform = true;
        _animator = GetComponent<Animator>();
      spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
      spriteRenderer1 = GameObject.FindGameObjectWithTag("player2").GetComponentInChildren<SpriteRenderer>();
      spriteRenderer2 = GameObject.FindGameObjectWithTag("player3").GetComponentInChildren<SpriteRenderer>();
      spriteRenderer3 = GameObject.FindGameObjectWithTag("player4").GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("setCharacter") == 0)
        {
            spriteRenderer.enabled = true;
            spriteRenderer1.enabled = false;
            spriteRenderer2.enabled = false;
            spriteRenderer3.enabled = false;
        }
        if (PlayerPrefs.GetInt("setCharacter") == 1)
        {
            spriteRenderer.enabled = false;
            spriteRenderer1.enabled = true;
            spriteRenderer2.enabled = false;
            spriteRenderer3.enabled = false;
        }
        if (PlayerPrefs.GetInt("setCharacter") == 2)
        {
            spriteRenderer.enabled = false;
            spriteRenderer1.enabled = false;
            spriteRenderer2.enabled = true;
            spriteRenderer3.enabled = false;
        }
        if (PlayerPrefs.GetInt("setCharacter") == 3)
        {
            spriteRenderer.enabled = false;
            spriteRenderer1.enabled = false;
            spriteRenderer2.enabled = false;
            spriteRenderer3.enabled = true;
        }
        _isOnPlatform = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        _rigidbody2D.velocity = new Vector2(playerSpeed,_rigidbody2D.velocity.y);
        
        if (Input.GetKeyDown(KeyCode.Mouse0) && _isOnPlatform)
        {
            _rigidbody2D.velocity = new Vector2(playerSpeed,jumpSpeed);
            _isOnPlatform = false;
            
        }
       
    }
}
