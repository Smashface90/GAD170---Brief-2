//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class randomiser : MonoBehaviour
//{
//    public GameObject character1_Row1;
//    public GameObject character2_Row1;
//    public GameObject character3_Row1;
//    [Space]
//    public GameObject character1_Row2;
//    public GameObject character2_Row2;
//    public GameObject character3_Row2;
//    [Space]
//    public GameObject character1_Row3;
//    public GameObject character2_Row3;
//    public GameObject character3_Row3;

//    //References
//    BaseStats base_Stats;

//    private void Awake()
//    {
//        base_Stats = FindObjectOfType<BaseStats>();
//    }

//    // Start is called before the first frame update
//    void Start()
//    {
//        Randomiser();
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }

//    public int Randomiser()
//    {
//        int randomNum;

//        randomNum = Random.Range(1, 10);


//        switch (randomNum)
//        {
//            case (1):
//                print("Number is 1");

//                //Row 1
//                character1_Row1.SetActive(true);
//                character2_Row1.SetActive(false);
//                character3_Row1.SetActive(false);

//                //Row 2
//                //character1_Row1.SetActive(true);
//                //character2_Row1.SetActive(false);
//                //character3_Row1.SetActive(false);


//                break;
//            case (2):
//                print("Number is 2");

//                character1_Row1.SetActive(false);
//                character2_Row1.SetActive(true);
//                character3_Row1.SetActive(false);

//                break;
//            case (3):
//                print("Number is 3");

//                character1_Row1.SetActive(false);
//                character2_Row1.SetActive(false);
//                character3_Row1.SetActive(true);

//                break;
//            case (4):
//               print("Number is 4");

//                break;
//            case (5):
//                print("Number is 5");

//                break;
//            case (6):
//                print("Number is 6");

//                break;
//            case (7):

//                break;
//            case (8):

//                break;
//            case (9):

//                break;
           
//        }

//        return randomNum;

//    }


//}
