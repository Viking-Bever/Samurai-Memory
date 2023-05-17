using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Axeman : MonoBehaviour
{
    public List<int> keyPressOrder = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        keyPressOrder = GetComponent<Player>().KeyPressOrder;
    }

    // Update is called once per frame
    void Update()
    {
        if (keyPressOrder[0] == 1)
        {
            GetComponent<Animator>().Play("WoodUpA");
        }
    }
  /*  public void attackani()
    {
        if (keyPressOrder[0] == 1)
        {
            GetComponent<Animator>().Play("attackJump");
        }
    }
*/
}
