using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruit : MonoBehaviour
{
    public Text myText;
    public Image imagePrefab;
    public List<string> itemList = new List<string>();
    public List<Sprite> images = new List<Sprite>();
    public Sprite Toyota;
    public Sprite Honda;
    public Sprite Mazda;
    public Sprite Nissan;
    public Sprite Suzuki;

    // Start is called before the first frame update
    void Start()
    {
        images.Add(Toyota);
        images.Add(Honda);
        images.Add(Mazda);
        images.Add(Nissan);
        images.Add(Suzuki);

        itemList.Add("Toyota");
        itemList.Add("Honda");
        itemList.Add("Mazda");
        itemList.Add("Nissan");
        itemList.Add("Suzuki");
        myText.text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" + itemList[3] + "\n" + itemList[4];

    }

    // Update is called once per frame
    void Update()
    {
        imagePrefab.GetComponent<Image>().sprite = images[0];

        if (Input.GetKeyDown(KeyCode.Return))
        {
            //myText.text = itemList[0];
            itemList.RemoveAt(0);
            images.RemoveAt(0);
            itemList.Add("");

        }
        foreach (string str in itemList)
        {
            myText.GetComponent<Text>().text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" + itemList[3] + "\n" + itemList[4];

        }
    }


}