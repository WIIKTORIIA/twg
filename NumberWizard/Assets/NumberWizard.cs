using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
	// globalny zakres klasy
	int max;
	int min;
	int guess;
    // to oznacza że pierwszym strzałem jest wartość 500 i jest to środek naszego przedziału
    public Text text;
	// zakres metody Start()
	void Start ()
	{
		StartGame ();
	}

	void StartGame()
	{
		max = 1000;
		min = 1;
		guess = 500;
        text.text = "================================= \n" +
                    "Witaj u Liczbowego Czarodzieja \n" +
                    " Pomyśl liczbe w swojej glowie, ale nie mow jej na głos \n" +
                    "Najwieksza liczba jaka możesz wybrac jest " + max + "\n" +
                    "Najmniejsza  liczba jaka możesz wybrac jest " + min + "\n" +
                    " Czy twoja liczba jest wieksza czy mniejsza od " + guess + " ?";
		/**print("===================================");
		print ("Witaj u Liczbowego Czarodzieja");
		print (" Pomyśl liczbe w swojej glowie, ale nie mow jej na głos");
		print ("Najwieksza liczba jaka możesz wybrac jest " + max);
		print ("Najmniejsza  liczba jaka możesz wybrac jest " + min);
		print (" Czy twoja liczba jest wieksza czy mniejsza od " + guess + " ?");
		print (" Aby odpowiedzieć na pytanie: Górną strzałka = wyższa liczba, dolna strzałka = niższa strzałka i enter = równa");**/
		max = max + 1; // max+=1;
	}

	void NextGuess()
	{
		guess = (max + min) / 2;
		text.text = " Czy twoja liczba jest wieksza czy mniejsza od " + guess + " ?";
	}

    public void smaller()
    {
        max = guess;
        NextGuess();
    }

    public void bigger()
    {
        min = guess;
        NextGuess();
    }

    public void win()
    {
        text.text = "Wygrałeś!!!! ^_^";
    }

    public void reset()
    {
        StartGame();
    }

    void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess ();

		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess ();

		}else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Wygrałem");
			StartGame ();
		}
		/* */
		/* SCOPE */
	}
}

