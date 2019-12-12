using System.Threading;
using System.Diagnostics;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField]
    private float forca = 6;
    

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>(); //VARIAVEL FISICA RECEBE RIGD BODY
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //BOATAO CLICK ESSQUERDO DO MOUSE
        {
           this.Impulsionar();
        }
    }

    private void Impulsionar () //MÉTODO PARA IMPULSIONAR O AVIAO QUANDO CLICAR
    {
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse); 
    }
}
