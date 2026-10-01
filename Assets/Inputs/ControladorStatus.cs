using UnityEngine;

public class ControladorStatus : MonoBehaviour
{
    const int LIMITE_VIDA = 100;

    private float velocidadeJogador = 15.0f;
    private int pontosVida = 50;
    private int escudo = 20;
    private int energia = 40;
    private int xp = 120;
    private int nivel = 1;
    private string nomePersonagem = "Guerreiro";
    private bool estaVivo = true;
    private bool temPocao = true;
    private bool emCombate = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int danoRecebido = 30;

        if (escudo >= danoRecebido)
        {
            danoRecebido -= escudo;

        }
        else
        {
            int danoRestande = danoRecebido - escudo;
            escudo = 0;
            danoRestande -= pontosVida;
        }

        if (pontosVida <= 0)
        {
            pontosVida = 0;
            estaVivo = false;
        }

        else
        {
            estaVivo = true;
        }

        if ( (energia < 50 && temPocao = true) || emCombate = true)
        {
            energia += 30;
            temPocao = false;  
        }

        else
        {
            energia += 5;
        }

        if (xp >= 50)
        {


        }

        if (xp >= 50)
        {


        }

        if (xp >= 50)
        {


        }

        string estado = "Parado";
        bool estaAtordoado = false;

        if (estaAtordoado = true)
        {
            velocidadeJogador = 0.0f;
            estado = "Atordoado";

        }

        else if (velocidadeJogador >10.0f)
        {
            estado = "Correndo";
            velocidadeJogador += 5.0f;
        }

        else if (velocidadeJogador > 0.0f)
        {
            estado = "Andando";
        }

        else
        {
            estado = "Parado";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
