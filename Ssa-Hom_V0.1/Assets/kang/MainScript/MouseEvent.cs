using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.IO;
using System.Xml;


public class MouseEvent : MonoBehaviour
{
    // public RectTransform transform_cursor;
    public RectTransform transform_tooltips;
    public  Text text_mouse;

    void Start()
    {

       // skill1 = GameObject.Find("이미지");
       
    }

    // Update is called once per frame
    void Update()
    {
        //Update_MousePosition();
    }

    /*private void Init_Cursor()
    {
        Cursor.visible = false;
        transform_cursor.pivot = Vector2.up;

        if (transform_cursor.GetComponent<Graphic>())
            transform_cursor.GetComponent<Graphic>().raycastTarget = false;
        if (transform_tooltips.GetComponent<Graphic>())
            transform_tooltips.GetComponent<Graphic>().raycastTarget = false;
    }*/


    public void ShowTooltip()
    {
        Debug.Log("스킬을 추가해주세요");
        //tooltip.SetActive(true);
    }

    public void HideTooltip()
    {
        Debug.Log("내려갔다잇");
        Vector2 mousePos = Input.mousePosition;
        //transform_cursor.position = mousePos;
        float w = transform_tooltips.rect.width;
        float h = transform_tooltips.rect.height;
        transform_tooltips.position = mousePos + (new Vector2(w, h) * 10); // 툴팁 가리개
    }


    public void Update_MousePosition()
    {
        Debug.Log("올라갔다잇");
        Vector2 mousePos = Input.mousePosition;
        //transform_cursor.position = mousePos;
        float w = transform_tooltips.rect.width;
        float h = transform_tooltips.rect.height;
        transform_tooltips.position = mousePos - (new Vector2(w, h) * 0.7f);
    }

    public void AdToolTip()
    {
        GameObject AdTipText;
        AdTipText = GameObject.Find("AdTipText");
        int id = PlayerPrefs.GetInt("id");
        string path = Path.Combine(Application.streamingAssetsPath, "StatDataTest.xml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[id];
        int i = int.Parse(character.SelectSingleNode("ad").InnerText);
        double result = System.Math.Truncate((double)i / 10);
        result += 1;
        AdTipText.GetComponent<Text>().text = result.ToString() + " 의 능력치가 필요합니다.";
        Debug.Log("올라갔다잇");
        Vector2 mousePos = Input.mousePosition;
        //transform_cursor.position = mousePos;
        float w = transform_tooltips.rect.width;
        float h = transform_tooltips.rect.height;
        transform_tooltips.position = mousePos - (new Vector2(w, h) * 0.7f);
    }

    public void MpToolTip()
    {
        GameObject MpTipText;
        MpTipText = GameObject.Find("MpTipText");
        int id = PlayerPrefs.GetInt("id");
        string path = Path.Combine(Application.streamingAssetsPath, "StatDataTest.xml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[id];
        int i = int.Parse(character.SelectSingleNode("mp").InnerText);
        double result = System.Math.Truncate((double)i / 10);
        result += 1;
        MpTipText.GetComponent<Text>().text = result.ToString() + " 의 능력치가 필요합니다.";
        Debug.Log("올라갔다잇");
        Vector2 mousePos = Input.mousePosition;
        //transform_cursor.position = mousePos;
        float w = transform_tooltips.rect.width;
        float h = transform_tooltips.rect.height;
        transform_tooltips.position = mousePos + (new Vector2(w, h) * 0.7f);
    }

    public void ApToolTip()
    {
        GameObject ApTipText;
        ApTipText = GameObject.Find("ApTipText");
        int id = PlayerPrefs.GetInt("id");
        string path = Path.Combine(Application.streamingAssetsPath, "StatDataTest.xml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[id];
        int i = int.Parse(character.SelectSingleNode("ap").InnerText);
        double result = System.Math.Truncate((double)i / 10);
        result += 1;
        ApTipText.GetComponent<Text>().text = result.ToString() + " 의 능력치가 필요합니다.";
        Debug.Log("올라갔다잇");
        Vector2 mousePos = Input.mousePosition;
        //transform_cursor.position = mousePos;
        float w = transform_tooltips.rect.width;
        float h = transform_tooltips.rect.height;
        transform_tooltips.position = mousePos - (new Vector2(w, h) * 0.7f);
    }

    public void HpToolTip()
    {
        GameObject HpTipText;
        HpTipText = GameObject.Find("HpTipText");
        int id = PlayerPrefs.GetInt("id");
        string path = Path.Combine(Application.streamingAssetsPath, "StatDataTest.xml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[id];
        int i = int.Parse(character.SelectSingleNode("hp").InnerText);
        double result = System.Math.Truncate((double)i / 10);
        result += 1;
        HpTipText.GetComponent<Text>().text = result.ToString() + " 의 능력치가 필요합니다.";
        Debug.Log("올라갔다잇");
        Vector2 mousePos = Input.mousePosition;
        //transform_cursor.position = mousePos;
        float w = transform_tooltips.rect.width;
        float h = transform_tooltips.rect.height;
        transform_tooltips.position = mousePos - (new Vector2(w, h) * 0.7f);
    }


}
