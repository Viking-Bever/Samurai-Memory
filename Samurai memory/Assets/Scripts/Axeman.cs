using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;

public class Axeman : MonoBehaviour
{
    public List<int> KeyPressOrder;
    [SerializeField] public GameObject Player;
    [SerializeField] public GameObject GameMananger;
    public bool k�r;
    public bool Ninjal�s;
    // Start is called before the first frame update
    void Start()
    {
        k�r = false;
        Ninjal�s = false;
           List<int> KeyPressOrder = new List<int>();
    }

    // Update is called once per frame
    void Update()
    {
     /*  // Player.GetComponent<Player>().changeK�r();
        if (GameMananger.GetComponent<GameMananger>().AxeManStatus())
        {
            KeyPressOrder = Player.GetComponent<Player>().SkickaOrdning();
            if (KeyPressOrder[0] == 1)
            {
                GetComponent<Animator>().Play("WoodUpA");
                KeyPressOrder.RemoveAt(0);
            }
            if (KeyPressOrder[0] == 0)
            {
                GetComponent<Animator>().Play("WoodDownA");
                KeyPressOrder.RemoveAt(0);
            }
            if (KeyPressOrder[0] == 2)
            {
                GetComponent<Animator>().Play("WoodRightA");
                KeyPressOrder.RemoveAt(0);
            }
        }
        if (KeyPressOrder.Count == 0)// && GameMananger.GetComponent<GameMananger>().Ninjal�s == false)
        {
            if (GameMananger.GetComponent<GameMananger>().PlayerStatus() == false)
            {
                GameMananger.GetComponent<GameMananger>().changeNinjal�s();
                GameMananger.GetComponent<GameMananger>().changeK�r();
            }
         } */ 
    }
    public void PlayAnimations(List<int> KeyPressOrder)
    {
        KeyPressOrder = Player.GetComponent<Player>().SkickaOrdning();
        if (KeyPressOrder[0] == 1)
        {
            GetComponent<Animator>().Play("WoodUpA");
            KeyPressOrder.RemoveAt(0);
        }
        if (KeyPressOrder[0] == 0)
        {
            GetComponent<Animator>().Play("WoodDownA");
            KeyPressOrder.RemoveAt(0);
        }
        if (KeyPressOrder[0] == 2)
        {
            GetComponent<Animator>().Play("WoodRightA");
            KeyPressOrder.RemoveAt(0);
        }
        Player.GetComponent<Player>().Ninjal�s = true;
       // StartCoroutine(PlayAnimations());
    }

    /*IEnumerator PlayAnimations()
    {
        if(!GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("WoodRightA"))
        {
            yield return null;
            
        }
        if (!GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("WoodDownA"))
        {
            yield return null;
        }
        if (!GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("WoodUpA"))
        {
            yield return null;
        }
    }*/
}
