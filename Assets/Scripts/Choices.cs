using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choices : MonoBehaviour
{
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject ContinueButton;
    public GameObject ResultsText;
    public GameObject EndGameResultsText;
    public GameObject Man1;
    public GameObject Man2;
    public GameObject Horse1;
    public GameObject Horse2;
    public GameObject OldMan1;
    public GameObject OldMan2;
    public GameObject King1;
    public GameObject King2;
    public int Result1;
    public int Result2;
    public int Result3;
    public int Result4;
    public int Result5;
    public int Result6;
    public int Result7;
    public int Result8;
    public int Result9;
    public int Result10;
    public bool ChoiceMade;
    public int random;
    public int scenarioRandom;
    public int day;
    public int Explorer;
    public int ExplorerScore;
    public int Achiever;
    public int AchieverScore;
    public int Socialiser;
    public int SocialiserScore;
    public int Killer;
    public int KillerScore;
    List<int> RandomList = new List<int>();

    private void Start()
    {
        for (int n = 0; n < 10; n++)
        {
            RandomList.Add(n);
        }

        Randomiser();
        NewScenario();
    }

    private void OnEnable()
    {
        day = 0;
        ChoiceMade = false;
    }

    public void Loop()
    {
        day++;
        print(day);
        NewScenario();
    }

    public void Randomiser()
    {
        int randomnum = Random.Range(0, RandomList.Count);
        random = RandomList[randomnum];
        RandomList.RemoveAt(randomnum);
    }

    public void ChoiceOption1()
    {
        if (random == 0)
        {
            ResultsText.GetComponentInChildren<Text>().text = "This is going to harm peoples jobs, and our people will starve.";
            KillerScore++;
            Result1 = 0;
}
        if (random == 1)
        {
            ResultsText.GetComponentInChildren<Text>().text = "Why would you do this! The kingdom is running low on water.";
            KillerScore++;
            Result2 = 0;
        }
        if (random == 2)
        {
            ResultsText.GetComponentInChildren<Text>().text = "You dominate the fight and the warrior yields, you win!";
            KillerScore++;
            Result3 = 0;
        }
        if (random == 3)
        {
            ResultsText.GetComponentInChildren<Text>().text = "You will strike fear into the hearts of potential enemies";
            KillerScore++;
            Result4 = 0;
        }
        if (random == 4)
        {
            ResultsText.GetComponentInChildren<Text>().text = "You will be known as the best King of all time";
            KillerScore++;
            Result5 = 0;
        }
        if (random == 5)
        {
            ResultsText.GetComponentInChildren<Text>().text = "You found a large crocodile swimming in the water, it has been tamed and is your new pet.";
            ExplorerScore++;
            Result6 = 0;
        }
        if (random == 6)
        {
            ResultsText.GetComponentInChildren<Text>().text = "You learned about how the Kingdom came to be, you found it very interesting .";
            ExplorerScore++;
            Result7 = 0;
        }
        if (random == 7)
        {
            ResultsText.GetComponentInChildren<Text>().text = "The new town looks to be a promising expansion of the Kingdom";
            ExplorerScore++;
            Result8 = 0;
        }
        if (random == 8)
        {
            ResultsText.GetComponentInChildren<Text>().text = "Their people won't like it, but their land is ours now. Harsh, but The King will be pleased.";
            AchieverScore++;
            Result9 = 0;
        }
        if (random == 9)
        {
            ResultsText.GetComponentInChildren<Text>().text = "Much better! You found hidden treasures while cleaning!";
            AchieverScore++;
            Result10 = 0;
        }
        OldMan1.SetActive(false);
        OldMan2.SetActive(false);
        Horse1.SetActive(false);
        Horse2.SetActive(false);
        Man1.SetActive(false);
        Man2.SetActive(false);
        King1.SetActive(false);
        King2.SetActive(false);
        toggleChoice();
    }

    public void ChoiceOption2()
    {
        if (random == 0)
        {
            ResultsText.GetComponentInChildren<Text>().text = "You were attacked by a mythical creature and suffered injuries, a group of hunters saved you and joined the Kingdom";
            ExplorerScore++;
            Result1 = 1;
        }
        if (random == 1)
        {
            ResultsText.GetComponentInChildren<Text>().text = "The gold was stolen undetected, well done.";
            AchieverScore++;
            Result2 = 1;
        }
        if (random == 2)
        {
            ResultsText.GetComponentInChildren<Text>().text = "The road is a success and citizens are already making use of it!";
            SocialiserScore++;
            Result3 = 1;
        }
        if (random == 3)
        {
            ResultsText.GetComponentInChildren<Text>().text = "The party went on into the early hours of the morning and everyone had fun!";
            SocialiserScore++;
            Result4 = 1;
        }
        if (random == 4)
        {
            ResultsText.GetComponentInChildren<Text>().text = "You found rubies and diamonds!";
            ExplorerScore++;
            Result5 = 1;
        }
        if (random == 5)
        {
            ResultsText.GetComponentInChildren<Text>().text = "You came 2nd in the tournament! This has boosted morale for the whole Kingdom";
            AchieverScore++;
            Result6 = 1;
        }
        if (random == 6)
        {
            ResultsText.GetComponentInChildren<Text>().text = "Diplomacy will be much easier now.";
            AchieverScore++;
            Result7 = 1;
        }
        if (random == 7)
        {
            ResultsText.GetComponentInChildren<Text>().text = "Great! Everyone loves you and morale has been boosted";
            SocialiserScore++;
            Result8 = 1;
        }
        if (random == 8)
        {
            ResultsText.GetComponentInChildren<Text>().text = "The alliance goes to plan and everyone is stronger for it";
            SocialiserScore++;
            Result9 = 1;
        }
        if (random == 9)
        {
            ResultsText.GetComponentInChildren<Text>().text = "The alliance has improved the overall health of the Kingdom";
            SocialiserScore++;
            Result10 = 1;
        }
        OldMan1.SetActive(false);
        OldMan2.SetActive(false);
        Horse1.SetActive(false);
        Horse2.SetActive(false);
        Man1.SetActive(false);
        Man2.SetActive(false);
        King1.SetActive(false);
        King2.SetActive(false);
        toggleChoice();
    }

    public void Continue()
    {
        if (day == 9)
        {
            ContinueButton.SetActive(false);
            ResultsText.SetActive(false);

            string resultsCopied = SocialiserScore.ToString() + KillerScore.ToString() + AchieverScore.ToString() + ExplorerScore.ToString() + Result1.ToString() + Result2.ToString() + Result3.ToString() + Result4.ToString() + Result5.ToString() + Result6.ToString() + Result7.ToString() + Result8.ToString() + Result9.ToString() + Result10.ToString();
            GUIUtility.systemCopyBuffer = resultsCopied; 
            EndGameResultsText.GetComponentInChildren<InputField>().text = resultsCopied;
            EndGameResultsText.SetActive(true);
        }
        else
        {
            toggleChoice();
            Randomiser();
            Loop();
        }

        
    }

    private void toggleChoice()
    {
        ChoiceMade = !ChoiceMade;

        Choice01.SetActive(!ChoiceMade);
        Choice02.SetActive(!ChoiceMade);
        ContinueButton.SetActive(ChoiceMade);
        ResultsText.SetActive(ChoiceMade);
    }

    private void Update()
    {

    }

    void NewScenario()
    {
        if (random == 0)
        {
            Choice01.GetComponentInChildren<Text>().text = "Sabotage the Farms on the outskirts of Town";
            Man1.SetActive(true);
            Horse2.SetActive(true);
            Choice02.GetComponentInChildren<Text>().text = "There are rumours of something hidden in the Forest nearby, do you want to explore?";
            Killer++;
            Explorer++;
        }

        if (random == 1)
        {
            Choice01.GetComponentInChildren<Text>().text = "Poison the central Water Well";
            Man1.SetActive(true);
            Man2.SetActive(true);
            Choice02.GetComponentInChildren<Text>().text = "We have a spy in another town, would you like to steal some gold?";
            Killer++;
            Achiever++;
        }

        if (random == 2)
        {
            Choice01.GetComponentInChildren<Text>().text = "Challenge the best warrior to a duel";
            Man1.SetActive(true);
            King2.SetActive(true);
            Choice02.GetComponentInChildren<Text>().text = "Build a road to a neighboring Kingdom";
            Killer++;
            Socialiser++;
        }

        if (random == 3)
        {
            Choice01.GetComponentInChildren<Text>().text = "Make yourself Captain of the Guards";
            Horse1.SetActive(true);
            OldMan2.SetActive(true);
            Choice02.GetComponentInChildren<Text>().text = "Plan a party";
            Killer++;
            Socialiser++;
        }

        if (random == 4)
        {
            Choice01.GetComponentInChildren<Text>().text = "Implement a King Leaderboard system, and place yourself at the top of it";
            Man1.SetActive(true);
            Horse2.SetActive(true);
            Choice02.GetComponentInChildren<Text>().text = "A map suggests there are hidden jewels in the City Sewers, would you like to explore them?";
            Killer++;
            Explorer++;
        }

        if (random == 5)
        {
            Choice01.GetComponentInChildren<Text>().text = "There are rumours of a monster in the Forbidden Swamp, would you like to send a team out to investigate?";
            Horse1.SetActive(true);
            Horse2.SetActive(true);
            Choice02.GetComponentInChildren<Text>().text = "Compete in the Jousting Tournament";
            Explorer++;
            Achiever++;
        }

        if (random == 6)
        {
            Choice01.GetComponentInChildren<Text>().text = "Read Ancient texts from the Private Library";
            OldMan2.SetActive(true);
            Choice02.GetComponentInChildren<Text>().text = "A travelling merchant has came into town, they will coach you in negotiation tactics if you pay them";
            Explorer++;
            Achiever++;
        }

        if (random == 7)
        {
            Choice01.GetComponentInChildren<Text>().text = "Send a Settler to build a new town";
            Horse2.SetActive(true);
            OldMan2.SetActive(true);
            Choice02.GetComponentInChildren<Text>().text = "Go to the tavern to chat with townsfolk";
            Explorer++;
            Socialiser++;
        }

        if (random == 8)
        {
            Choice01.GetComponentInChildren<Text>().text = "We have a spy in another town, would you like to take down their Kingdom and take it for yourself?";
            Man1.SetActive(true);
            King2.SetActive(true);
            Choice02.GetComponentInChildren<Text>().text = "A Union has been proposed between surrounding Kingdoms, do you want to join it?";
            Achiever++;
            Socialiser++;
        }

        if (random == 9)
        {
            Choice01.GetComponentInChildren<Text>().text = "The trophy room is a mess, would you like to organise it?";
            Man1.SetActive(true);
            King2.SetActive(true);
            Choice02.GetComponentInChildren<Text>().text = "Create an alliance with another Kingdom";
            Achiever++;
            Socialiser++;
        }

    }
}

