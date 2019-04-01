using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoreNavigator2 : MonoBehaviour
{
    public int loreIndex;

    public Text info;

    public GameObject[] displayObjs;

    void Start()
    {
        loreIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (loreIndex == 44)
        {
            loreIndex = 0;
        }

        switch (loreIndex)
        {

            case 0:

                info.text = "jhkjkj.";

                displayObjs[43].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 1:

                info.text = "It was built in S. XVI, around 500 years ago, close to Lima's foundation.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 2:

                info.text = "This settlement is connected to the Inca Road, as many of other sites.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 3:

                info.text = "Among these debris is the Curaca´s house, a holy warrior priest.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 4:

                info.text = "At Curaca´s house it was found a stone mace with wooden grip and spondylus art.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 5:

                info.text = "Some rooms have been identified as kitchens, dormitories and patios.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 6:

                info.text = "There has been found several corpses buried with and without offerings.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 7:

                info.text = "The largest building was the Church. Gnome worship was abolished. Curaca´s house is the one on the top left in the corner.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 8:

                info.text = "After a long and inclined climb/walk there can be seen a couple of watchposts. The wind is strong at heights.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 9:

                info.text = "The valley, agro-fields and residential zone can be seen all around. Deep into the valley, after 2hrs of walk there is a big cactus valley, fierce insect and animals lurks there. ";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 10:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 11:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 12:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 13:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 14:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 15:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 16:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 17:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 18:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 19:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 20:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 21:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 22:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 23:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 24:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 25:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 26:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 27:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 28:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 29:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 30:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 31:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 32:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 33:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 34:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 35:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 36:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 37:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 38:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 39:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 40:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 41:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 42:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 43:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 44:

                info.text = "tafkldnfsdkjfd";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            default:
                info.text = "";

                break;
        }


    }

    public void DisplayNextItem()
    {
        loreIndex++;
    }

}
