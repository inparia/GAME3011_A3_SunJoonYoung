using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScore : MonoBehaviour
{
    public TMPro.TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = "Your Score Was : " + GameManager.instance.lastScore.ToString();
    }
}
