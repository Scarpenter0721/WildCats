using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour//, IDataPersistence
{

    public float movementSpeed = 3f;
    public float jumpForce = 10f;
    public float timeBeforeNextJump = 1.2f;
    Animator anim;
    Rigidbody rb;
    public LayerMask start;
    public LayerMask ground;
    public Transform groundCheck;

    public TextMeshProUGUI lives;
    public int playerLives = StaticManager.playerLives;

    public AudioSource source;
    public AudioClip pickUp;


    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ControllPlayer();
        lives.text = StaticManager.playerLives.ToString();
    }

    void ControllPlayer()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);
            anim.SetInteger("Walk", 1);
        }
        else {
            anim.SetInteger("Walk", 0);
        }

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

        
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            anim.SetTrigger("jump");
        }
        if (Physics.CheckSphere(groundCheck.position, .1f, ground))
        {
            playerLives--;
            StaticManager.playerLives = playerLives;
            if(playerLives <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
            Debug.Log(StaticManager.playerLives);
            transform.position = new Vector3(-88, 2, -30);
        }
        if(Input.GetKeyDown(KeyCode.P)&& !StaticManager.paused)
        {
            StaticManager.paused = true;
            Time.timeScale = 0f;
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            AchievementManager.instance.ResetAchievementState();
        }
    }
    

    
    bool IsGrounded()
{

    return Physics.CheckSphere(groundCheck.position, .1f, start);
}
    //public void LoadData(GameData data)
    //{
    //    this.transform.position = data.playerPosition;
    //    this.playerLives = data.livesLeft;
    //    //StaticManager.playerLives = livesLeft;
    //}

    //public void SaveData(ref GameData data)
    //{
    //    data.playerPosition = this.transform.position;
    //    data.livesLeft = this.playerLives;
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Diamond")
        {
            source.clip = pickUp;
            source.Play();
        }
    }

}