using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private List<int> KeyPressOrder = new List<int>();
    public int Health = 100;
    public Text textOrder;
    private Animator _anim;
    private bool JA = false;
    private bool DA = false;
    private bool RA = false;
    private bool DMG = false;
    // Start is called before the first frame update
    void Start()
    {
        RandomOrder();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            GetComponent<Animator>().SetBool("DA", true);
            DA = true;
            Attack(0);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            GetComponent<Animator>().SetBool("JA", true);
            JA = true;
            Attack(1);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            GetComponent<Animator>().SetBool("RA", true);
            RA = true;
            Attack(2);
        }
    }

    void Attack(short button)
    {
        if (button == KeyPressOrder[0])
        {
            Debug.Log("Rätt");
            KeyPressOrder.RemoveAt(0);

            if (KeyPressOrder.Count == 0)
            {
                RandomOrder();
            }
        }
        else if (button != KeyPressOrder[0])
        {
            Debug.Log("Fel");
            TakeDmg();
            GetComponent<Animator>().SetBool("DMG", true);
            DMG = true;
            if (Health <= 10)
            {
                Debug.Log("You died");
            }

            //Debug.Log(Health);
        }
    }
    void RandomOrder()
    {
        for (int i = 0; i < 4; i++)
        {
            KeyPressOrder.Add(Random.Range(0, 3));
            Debug.Log(KeyPressOrder[i]);
        }
    }
    void TakeDmg()
    {
        Health -= 10;
    }
}
