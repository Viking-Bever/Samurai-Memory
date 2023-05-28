using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class Player : MonoBehaviour
{
    public List<int> KeyPressOrder = new List<int>();
    public int Health = 100;
    public int Score;
    [SerializeField] private Text TextOrdning;
    [SerializeField] public Text ScoreNum;
    [SerializeField] public GameObject ArrowU;
    [SerializeField] public GameObject ArrowD;
    [SerializeField] public GameObject ArrowR;
    [SerializeField] public GameObject Wolf;
    // Start is called before the first frame update
    void Start()
    {
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
            Debug.Log("Rätt");
            KeyPressOrder.RemoveAt(0);
            Score += 10;
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
        Health -= 10;
    }
}