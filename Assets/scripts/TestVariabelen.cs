using UnityEngine;

public class testvariabele : MonoBehaviour
{

    string naam = "Niniveh" + "van" + "Meer";
    int leeftijd = 15;
    bool IsEenGoedeStudent = true;

    double BankInhoud = 132.55d;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("Hallo mijn naam is " + naam);
            Debug.Log("mijn leeftijd is" + leeftijd);
            Debug.Log("ik ben een goede student" + IsEenGoedeStudent);
        Debug.Log("op mijn bankrekening staat" + BankInhoud);

    }

    // Update is called once per frame
    void Update()
    {

        if (leeftijd >= 15)
        {
            Debug.Log("Dit is een test");
        }


        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("druk op de spatiebalk");
        }


    }
}
