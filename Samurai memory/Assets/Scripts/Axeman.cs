using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Axeman : MonoBehaviour
{
    public List<int> KeyPressOrder;
    [SerializeField] public GameObject Player;
    public bool k�r;
    public bool Ninjal�s;
    // Start is called before the first frame update
    void Start()
    {
        k�r = false;
           List<int> KeyPressOrder = new List<int>();
    }

    // Update is called once per frame
    void Update()
    {
        if (k�r == true)
        {
            KeyPressOrder = Player.GetComponent<Player>().SkickaOrdning();
            if (KeyPressOrder[0] == 1)
            {
                GetComponent<Animator>().Play("WoodUpA");
                KeyPressOrder.RemoveAt(0);
            }
        }
    }
    public void changeNinjal�s()
    {
        if (Ninjal�s == true)
            Ninjal�s= false;
        else
            Ninjal�s = true;
    }
}
