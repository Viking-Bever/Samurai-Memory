using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<int> KeyPressOrder = new List<int>();
    public int Health = 100;
   
    // Start is called before the first frame update
    void Start()
    {
        RandomOrder();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Attack(0);
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Attack(1);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Attack(2);
        }
    }

    void Attack(short button)
    {
        if (button == KeyPressOrder[0])
        {
            Debug.Log("Rätt");
            KeyPressOrder.RemoveAt(0);
        }
        else
        {
            Debug.Log("Fel");
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
}
