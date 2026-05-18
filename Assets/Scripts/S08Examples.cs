using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class S08Examples : MonoBehaviour
{
    private List<string> mounstros 
        = new List<string>() {"Esqueleto" , "Orco" ,"Ogro","Goblin" };


    void Start()
    {
        for (int i = 0; i < mounstros.Count; i++)
        {

            //-> mounstros[0]
            print(mounstros[i]);
        }

        foreach (string item in mounstros)
        {
            print(item);
        }
        /* for (int i = 0; i <= 10; i++)
         {
             Debug.Log(i);
         }*/

        /*
        for (int i = 0; i <= 10; i+=2)
        {
            Debug.Log(i);
        }*/
        /*
        for (int i = 10; i > 0; i--)
        {
            Debug.Log(i);
        }*/


        /*
        for (int i = 0; i <= 15; i++)
        {
            if(i % 2 == 0)
            {
                print(i + " es par");
            }
            else
            {
                print(i + " es impar");
            }
        }*/


        //continue -> salta a la siguiente iteracion

        /*for (int i = 0; i <= 10; i++)
        {
            if (i == 5)
                continue;



            Debug.Log(i);
        }*/
        //break -> sale del bucle

        /*
        for (int i = 0; i <= 10; i++)
        {
            if (i == 5)
                break;



            Debug.Log(i);
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
