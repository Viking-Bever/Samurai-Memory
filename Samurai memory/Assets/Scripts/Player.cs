using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public List<int> KeyPressOrder = new List<int>();
    public int Health = 100;
    public int Score;
    private Animator _anim;
    [SerializeField] private Text TextOrdning;
    [SerializeField] public Text ScoreNum;
    [SerializeField] public GameObject GameMananger;
    //public bool kör;
    //public bool Ninjalås;

    private bool nedTryckt = false;
    // Start is called before the first frame update
    void Start()
    {
        RandomOrder();
        Skriv();
        GameMananger.GetComponent<GameMananger>().changeKör();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameMananger.GetComponent<GameMananger>().Ninjalås == true)
        {
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
        }
       // ScoreNum.text = Score;
        
    }

    void Attack(short key)
    {
        if (key == KeyPressOrder[0])
        {
            Debug.Log("Rätt");
            KeyPressOrder.RemoveAt(0);
            Score += 10;
            if (KeyPressOrder.Count == 0)
            {
                RandomOrder();
                GameMananger.GetComponent<GameMananger>().changeNinjalås();
                GameMananger.GetComponent<GameMananger>().changeKör();
            }
        }
        else if (key != KeyPressOrder[0])
        {
            Debug.Log("Fel");
            TakeDmg();
            GetComponent<Animator>().Play("dmg");
            if (Health <= 10)
            {
                Debug.Log("You died");
            }

            //Debug.Log(Health);
        }
    }
    void RandomOrder()
    {
        for (int i = 0; i < 3; i++)
        {
            KeyPressOrder.Add(Random.Range(0, 3));
            Debug.Log(KeyPressOrder[i]);
        }
        
    }
    void TakeDmg()
    {
        Health -= 10;
    }
    void Skriv()
    {
        string OrdningS = "";


        for (int i = 0; i < KeyPressOrder.Count; i++)
        {
            OrdningS += KeyPressOrder[i].ToString();
        }
        TextOrdning.text = OrdningS;

    }
    public List<int> SkickaOrdning()
    {
        return KeyPressOrder;
    }
}
