using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using UnityEngine.SceneManagement; 


public class Player : MonoBehaviour
{
    public AudioSource audioplayer;
    public AudioSource Aj;
    public List<int> KeyPressOrder = new List<int>();
    public int Health = 30;
    public int ScoreNum;
    public int HSnum; 

    [SerializeField] public Text TextOrdning;
    [SerializeField] public Text MyScoreText;
    [SerializeField] public Text HighScore; 
    [SerializeField] public GameObject ArrowU;
    [SerializeField] public GameObject ArrowD;
    [SerializeField] public GameObject ArrowR;
    [SerializeField] public GameObject Wolf;
    // Start is called before the first frame update
    void Start()
    {
        // tar senast highscore o lägger in. Om det inte finns något Highscore så e det 0. 
        HSnum = PlayerPrefs.GetInt("HS", 0); 
        // HS score texten + vad highscoret är. 
        HighScore.text = "Highscore: " + HSnum;

        //Score är = 0. Tar Score + 0. Score: 0. 
        ScoreNum = 0;
        MyScoreText.text = "Score: " + ScoreNum;

        //....
        RandomOrder();
    }

    // Update is called once per frame
    void Update()
    {
        // Kollar vilken knapp du trycker på

            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                GetComponent<Animator>().Play("attackDown");
                Attack(0);
            }
            else if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                GetComponent<Animator>().Play("attackJump");
                Attack(1);
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                GetComponent<Animator>().Play("attackRight");
                Attack(2);
            }

        //Bästmmer vilken av pilarna som ska vara aktiv
        if (KeyPressOrder[0] == 0)
        {
            ArrowD.SetActive(true);
            ArrowR.SetActive(false);
            ArrowU.SetActive(false);
        }
        if (KeyPressOrder[0] == 1)
        {
            ArrowU.SetActive(true);
            ArrowR.SetActive(false);
            ArrowD.SetActive(false);
        }
        if (KeyPressOrder[0] == 2)
        {
            ArrowR.SetActive(true);
            ArrowU.SetActive(false);
            ArrowD.SetActive(false);
        }
        // ScoreNum.text = Score;

    }
    //Attack metoden
    void Attack(short key)
    {
        //kollar om du tryckte rätt
        if (key == KeyPressOrder[0])
        {
            audioplayer.Play();
            //om du tryckte rätt då får du + en score. då uppdateras texten o lägger till +1. 
            ScoreNum += 1;
            MyScoreText.text = "Score: " + ScoreNum;

            // Kollar om scoret är högre än nu varandra highscoret. Om det är det. Så uppdateras highscoret. 
            if (HSnum < ScoreNum)
            {
                PlayerPrefs.SetInt("HS", ScoreNum);
            }
            

            Debug.Log("Rätt");
            KeyPressOrder.RemoveAt(0);
            


            if (KeyPressOrder.Count == 0)
            {
                RandomOrder();
            }

            
        }
        //kollar om du tryckte fel
        else if (key != KeyPressOrder[0])
        {
            Debug.Log("Fel");
            TakeDmg();
            Wolf.GetComponent<Animator>().Play("WolfA");
            GetComponent<Animator>().Play("dmg");
            if (Health <= 10)
            {
                Debug.Log("You died");
            }
        }
    }
    //Gör en random lista med 3 siffror
    void RandomOrder()
    {
        for (int i = 0; i < 3; i++)
        {
            KeyPressOrder.Add(Random.Range(0, 3));
            Debug.Log(KeyPressOrder[i]);
        }
    }
    //Tar skada
    void TakeDmg()
    {
        Aj.Play(); 
        Health -= 10;

        // Om ditt liv är 0. Så flyttas man till GameOver scenen. 
        if (Health == 0)
        {
            Debug.Log("Died"); 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }




}