using System.Diagnostics;
using System;
using System.Threading;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerador_obstaculo : MonoBehaviour
{
    [SerializeField]
    private float tempo_para_gerar;
    [SerializeField]
    private GameObject manual_de_instrucoes;
    private float cronometro;

    void Awake() {
        
        this.cronometro = this.tempo_para_gerar;
    }

    void Update()
    {
        this.cronometro -= Time.deltaTime; //DIFERENCA ENTRE A CHAMADA ANTERIOR E A ATUAL

        if (this.cronometro < 0)
        {
            GameObject.Instantiate(this.manual_de_instrucoes, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempo_para_gerar;
        }
        
        
    }
}
