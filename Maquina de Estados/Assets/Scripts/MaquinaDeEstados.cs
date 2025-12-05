using UnityEngine;

public class MaquinaDeEstados : MonoBehaviour
{
    enum STATE
    {
        PARADO,
        ANDANDO
    }
    STATE estado = STATE.PARADO;
    float speed = 2f;
    float tempo = 1f; 
    void Update()
    {
        tempo -= Time.deltaTime;
        if (tempo < 0f)
        {
            Mudanca();
            tempo = 1f;
        }       

        Atualiza();
    }
    public void Mudanca()
    {
        switch (estado) 
        { 
            case STATE.PARADO:
                estado = STATE.ANDANDO;
                break;
            case STATE.ANDANDO:
                estado = STATE.PARADO;
                break;
        }

    }
    public void Atualiza()
    {
        switch (estado) 
        {
            case STATE.PARADO:
                break;
            case STATE.ANDANDO:
                transform.position += new Vector3(0, speed * Time.deltaTime, 0);
                break;
        }
    }

}
