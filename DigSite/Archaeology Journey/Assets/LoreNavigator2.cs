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

                info.text = "Huaycan of Cieneguilla is an old settlement occupied between S. IX - XI by Ychmays. And between XI and XV there were also Incas.";

                displayObjs[43].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 1:

                info.text = "The merged culture of the inhabitants lived in this site since year 900 to 1500. The city is made of rock and clay.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 2:

                info.text = "The place has been restored but not reconstructed, to preserve as close as possible to the original.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 3:

                info.text = "There are two main zones in the city, the Left side correspond to Inca develop, the right to Ychmays.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 4:

                info.text = "The settlement has tunnels and tombs under the houses. The dead were buried at their own family homes.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 5:

                info.text = "There are several symbols and icons which may represent a mysterious, unknown and forgotten language. ";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 6:

                info.text = "Atop the hills, there are several walls of contention to protect the center. They work still today.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 7:

                info.text = "Tomb robbers have raided, pillaged and plundered most of treasures, artifacts and enviroment, still, several items have been found.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 8:

                info.text = "It was found all over the place the vegetal-made roofs of all the city, excepting particular patios or stone ceilings.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 9:

                info.text = "In certain parts there is more than one level to navigate the city.  ";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 10:

                info.text = "Last year a metal plate artifact was discovered. It was made of copper.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;

            case 11:

                info.text = "Some rooms in the higher ground have windows to behold the valley.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 12:

                info.text = "In all directions, in this case, the agriculture fields.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 13:

                info.text = "This dintel was found fallen. Weighting 400 kg, it was needed 16 people and 1 week to reposition it.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 14:

                info.text = "This corridor leads to an exit and after a walk, there is a connection to the Inca Road, To the other side: Pachacamac Sanctuary";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 15:

                info.text = "This canal has blockades in the ends. It was for sacrificial blood of many human offerings.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 16:

                info.text = "This city has (mainly) administrative purposes, unlike Pachacamac, which has religious ones.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 17:

                info.text = "The trapezoidal figure is typical from Inca arquitecture; it has anti-seismic purposes.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 18:

                info.text = "This Plateau was for the leaders, the Curaca, the Inca, and local authorities, such as the Administrator.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 19:

                info.text = "This patio had no ceiling and it may be used to conduct important state matters.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 20:

                info.text = "This big stone is called <batan> and is for grinding food.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 21:

                info.text = "Most of corridors and zones must had a special task at hand, such as interchange of goods, or alleys of artisans and specialist.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 22:

                info.text = "This view is from the Inca side to the Ychmay zone.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 23:

                info.text = "There are lots of design patterns in several places. Some are figures of entities, other geometrical shapes.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 24:

                info.text = "There is a vaast amount of rooms, recynths and diverse areas for many needs.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 25:

                info.text = "The stairs and ramps, as many other features of the site, are restored as the originals were supossed to be.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 26:

                info.text = "Pillagers tend to violenty remove artifacts from tombs, sometimes leaving corpses outside, thus, contaminating some unaccesible areas.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 27:

                info.text = "This tomb is near a crossroad. It was found with ceramics, offerings and artwork.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 28:

                info.text = "There are lots of stone incrustration among some walls. They supported heavy stone ceilings.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 29:

                info.text = "This tomb is dark and is hard to see what terrible and fearsome things lay beyond.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 30:

                info.text = "This batan is just outside a stone corridor leading to a big kitchen." ;

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 31:

                info.text = "It is said that this is a fox.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 32:

                info.text = "The first symbol is very recurred. The second one may represent the duality of two ceremonial blades.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 33:

                info.text = "This carves have not been identified. They may mean <Apu> which means the spirit of the mountain that protects each valley.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 34:

                info.text = "There is an intelligent pattern. Unluckily, the wall has fallen and it can be deciphred with ease.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 35:

                info.text = "Ychmay means red, there is still the faint rest of the crimson paintings in the wall of all the city.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 36:

                info.text = "This popular design has many interpretations such as <motherhood> or <humankind>. ";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 37:

                info.text = "Some of the circles are connected to the wall, some aren´t.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 38:

                info.text = "Since there are 12 symbols in a place, it was thought that may be some kind of calendar.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 39:

                info.text = "But we lack of knowledge to understand their conception of time-measuring.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 40:

                info.text = "This particular place is specially for blind visitors so they can feel the shapes.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 41:

                info.text = "Some of the protective clay is falling, so the rocks of the structure becomes exposed and visible.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 42:

                info.text = "Here it can be seen the importance of trapezoidal architecture.";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 43:

                info.text = "This is the rich tomb of one of the administrators of the town, it was found with his family. ";

                displayObjs[loreIndex - 1].SetActive(false);
                displayObjs[loreIndex].SetActive(true);
                break;


            case 44:

                info.text = "Path to Inca Road";

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
