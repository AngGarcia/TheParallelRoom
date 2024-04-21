using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FlowerSocketControl : MonoBehaviour
{

    public XRSocketInteractor socket;
    public FlowerPuzzle puzzle;
    private GameObject item;
    
    //0=BLUE
    //1=YELLOW
    //2=RED
    //3=ORANGE
    public int vaseType;
    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    public void SocketCheck()
    {
        item = socket.selectTarget.gameObject;
        if (item.CompareTag("BlueFlower") && vaseType == 0)
        {
            puzzle.numSolved++;
            if(puzzle.numSolved>=puzzle.numToSolve)
            {
                puzzle.winPuzzle();
            }
        }
        else if (item.CompareTag("YellowFlower") && vaseType == 1)
        {
            puzzle.numSolved++;
            if (puzzle.numSolved >= puzzle.numToSolve)
            {
                puzzle.winPuzzle();
            }
        }
        else if (item.CompareTag("RedFlower") && vaseType == 2)
        {
            puzzle.numSolved++;
            if (puzzle.numSolved >= puzzle.numToSolve)
            {
                puzzle.winPuzzle();
            }
        }
        else if (item.CompareTag("OrangeFlower") && vaseType == 3)
        {
            puzzle.numSolved++;
            if (puzzle.numSolved >= puzzle.numToSolve)
            {
                puzzle.winPuzzle();
            }
        }
    }

    public void SocketExitCheck()
    {
        if (item.CompareTag("BlueFlower") && vaseType == 0 && !puzzle.puzzlePassed)
        {
            puzzle.numSolved--;
            
        }
        else if (item.CompareTag("YellowFlower") && vaseType == 1 && !puzzle.puzzlePassed)
        {
            puzzle.numSolved--;
            
        }
        else if (item.CompareTag("RedFlower") && vaseType == 2 && !puzzle.puzzlePassed)
        {
            puzzle.numSolved--;
            
        }
        else if (item.CompareTag("OrangeFlower") && vaseType == 3 && !puzzle.puzzlePassed)
        {
            puzzle.numSolved--;
            
        }
    }


}
