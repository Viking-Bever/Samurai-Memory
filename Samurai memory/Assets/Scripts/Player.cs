using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<int> KeyPressOrder = new List<int>();
    public int Health = 100;
    bool PressRi = false;
    bool PressUp = false;
    bool PressDw = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            Attack();
            PressRi = true;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            PressUp = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PressDw = true;
        }
    }

    void Attack()
    {
        //Preform strike animation
        //check if the key was right
        //Deal damage


    }
}
