using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoreNavigator : MonoBehaviour
{
    public int loreIndex;

    public Text info;

    public GameObject[] displayObjs;


    // Start is called before the first frame update
    void Start()
    {
        loreIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (loreIndex == 10)
        {
            loreIndex = 0;
        }

        switch (loreIndex)
        {

            case 0:

                info.text = "Nieve Nieve is a settlement of spanish edification.";

                displayObjs[9].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 1:

                info.text = "It was built in S. XVI, around 500 years ago, close to Lima's foundation.";

                displayObjs[loreIndex -1].SetActive(false);
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
