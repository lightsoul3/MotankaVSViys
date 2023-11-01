using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palyer : MonoBehaviour
{
    public float speed;
    private float horizontalInput;
    private float verticalInput;

    public int redMagicCount = 0;
    public int orangeMagicCount = 0;
    public int greenMagicCount = 0;
    public int blueMagicCount = 0;
    public int yellowMagicCount = 0;
    public int pinkMagicCount = 0;
    public int purpleMagicCount = 0;
    public int enemyCount;

    public GameObject redMark;
    public GameObject orangeMark;
    public GameObject greenMark;
    public GameObject blueMark;
    public GameObject yellowMark;
    public GameObject pinkMark;
    public GameObject purpleMark;
    public GameObject explosion;
    public GameObject winPage;

    public GameObject magicSound;
    AudioSource audioSource1;
    public GameObject enemySound;
    AudioSource audioSource2;

    private Rigidbody2D rb;
    private Animator anim;
    private BoxCollider2D boxCollider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        rb.freezeRotation = true;

        audioSource1 = magicSound.GetComponent<AudioSource>();
        audioSource2 = enemySound.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (horizontalInput != 0 || verticalInput != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else if (horizontalInput == 0 && verticalInput == 0)
        {
            anim.SetBool("isRunning", false);
        }

        if (horizontalInput > 0)
        {
            anim.Play("run-right");
        }
        else if (horizontalInput < 0)
        {
            anim.Play("run");
        }
    }

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        rb.velocity = movement * speed;

    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("RedMagic") && orangeMagicCount <= 0 && yellowMagicCount <= 0 && greenMagicCount <= 0 && blueMagicCount <= 0
            && pinkMagicCount <= 0 && purpleMagicCount <= 0) 
        {
            redMagicCount++;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            redMark.SetActive(true);
            audioSource1.Play();
        }
        else if (other.CompareTag("RedViy") && redMagicCount != 0)
        {
            redMagicCount--;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            redMark.SetActive(false);
            enemyCount--;
            audioSource2.Play();
        }


        else if (other.CompareTag("OrangeMagic") && redMagicCount <= 0 && yellowMagicCount <= 0 && greenMagicCount <= 0 && blueMagicCount <= 0
            && pinkMagicCount <= 0 && purpleMagicCount <= 0)
        {
            orangeMagicCount++;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            orangeMark.SetActive(true);
            audioSource1.Play();
        }
        else if (other.CompareTag("OrangeViy") && orangeMagicCount != 0)
        {
            orangeMagicCount--;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            orangeMark.SetActive(false);
            enemyCount--;
            audioSource2.Play();
        }


        else if (other.CompareTag("GreenMagic") && redMagicCount <= 0 && yellowMagicCount <= 0 && orangeMagicCount <= 0 && blueMagicCount <= 0
            && pinkMagicCount <= 0 && purpleMagicCount <= 0)
        {
            greenMagicCount++;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            greenMark.SetActive(true);
            audioSource1.Play();
        }
        else if (other.CompareTag("GreenViy") && greenMagicCount != 0)
        {
            greenMagicCount--;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            greenMark.SetActive(false);
            enemyCount--;
            audioSource2.Play();
        }


        else if (other.CompareTag("YellowMagic") && redMagicCount <= 0 && greenMagicCount <= 0 && orangeMagicCount <= 0 && blueMagicCount <= 0
            && pinkMagicCount <= 0 && purpleMagicCount <= 0)
        {
            yellowMagicCount++;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            yellowMark.SetActive(true);
            audioSource1.Play();
        }
        else if (other.CompareTag("YellowViy") && yellowMagicCount != 0)
        {
            yellowMagicCount--;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            yellowMark.SetActive(false);
            enemyCount--;
            audioSource2.Play();
        }


        else if (other.CompareTag("BlueMagic") && redMagicCount <= 0 && yellowMagicCount <= 0 && orangeMagicCount <= 0 && greenMagicCount <= 0
            && pinkMagicCount <= 0 && purpleMagicCount <= 0)
        {
            blueMagicCount++;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            blueMark.SetActive(true);
            audioSource1.Play();
        }
        else if (other.CompareTag("BlueViy") && blueMagicCount != 0)
        {
            blueMagicCount--;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            blueMark.SetActive(false);
            enemyCount--;
            audioSource2.Play();
        }


        else if (other.CompareTag("PinkMagic") && redMagicCount <= 0 && yellowMagicCount <= 0 && orangeMagicCount <= 0 && greenMagicCount <= 0
            && blueMagicCount <= 0 && purpleMagicCount <= 0)
        {
            pinkMagicCount++;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            pinkMark.SetActive(true);
            audioSource1.Play();
        }
        else if (other.CompareTag("PinkViy") && pinkMagicCount != 0)
        {
            pinkMagicCount--;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            pinkMark.SetActive(false);
            enemyCount--;
            audioSource2.Play();
        }


        else if (other.CompareTag("PurpleMagic") && redMagicCount <= 0 && yellowMagicCount <= 0 && orangeMagicCount <= 0 && greenMagicCount <= 0
            && blueMagicCount <= 0 && pinkMagicCount <= 0)
        {
            purpleMagicCount++;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            purpleMark.SetActive(true);
            audioSource1.Play();
        }
        else if (other.CompareTag("PurpleViy") && purpleMagicCount != 0)
        {
            purpleMagicCount--;
            explosion.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.SetActive(false);
            Destroy(other.gameObject);
            purpleMark.SetActive(false);
            enemyCount--;
            audioSource2.Play();
        }

        if (enemyCount <= 0) 
        { 
            winPage.SetActive(true);
        }
    }
}
