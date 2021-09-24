using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{









    // Start is called before the first frame update
    void Start()
    {
        Mates(3,9);



       












    }

    // Update is called once per frame
    void Update()
    {










    }

    void Mates( int num1, int num2)
    {
        int r1 = (num1 + num2);

        int r2 = (num1 - num2);

        bool myBool;
        
        


        if (r2>=0)
        {
            myBool = true;

            print(myBool);
           
            print(num1 + " - " + num2 + " = " + r2);





        }
        else
        {
            myBool = false;

            print(myBool);

            print(num1 + " + " + num2 + " = " + r1);



        }




      







    }

    
}

        

        

    

    


    









