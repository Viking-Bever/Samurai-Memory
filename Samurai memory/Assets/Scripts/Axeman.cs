using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Axeman : MonoBehaviour
{
    public List<int> KeyPressOrder;
    [SerializeField] public GameObject Player;
    public bool kör;
    public bool Ninjalås;
    // Start is called before the first frame update
    void Start()
    {
        kör = false;
           List<int> KeyPressOrder = new List<int>();
    }

    // Update is called once per frame
    void Update()
    {
        if (kör == true)
        {
            KeyPressOrder = Player.GetComponent<Player>().SkickaOrdning();
            if (KeyPressOrder[0] == 1)
            {
                GetComponent<Animator>().Play("WoodUpA");
                KeyPressOrder.RemoveAt(0);
            }
        }
    }
    public void changeNinjalås()
    {
        if (Ninjalås == true)
            Ninjalås= false;
        else
            Ninjalås = true;
    }
}
