﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

public class GameState : MonoBehaviour
{
    public static Transform[,] chessboard=new Transform[8,8];
    public GameObject originalSquare;
    public Transform chessboardParent;
    public Transform chessPieces;
    const int SQUARE_SIZE = 2;
    // Start is called before the first frame update
  /*
 *  This class handles game state: it remembers current game state and allows others to check whether a move is valid
 */
public class GameState : MonoBehaviour
{
    string playerColor = "White";
    bool playersTurn = true;
    public static Transform[,] chessboard = new Transform[8,8]; // game state two-dimensiona array
    public GameObject originalSquare; // reference to square object we use to build the chessboard
    public Transform chessboardParent; // reference to container of our chessboard
    public Transform chessPieces; // reference to parent of all pieces
    const int SQUARE_SIZE = 2; // this constant allow us to scale our chessboard

    // the function below is "static" which means it can be called through class name, like that: GameState.isValidMove
    // without a need to have a reference to this class. Using "static" is OK only for classes that for sure have just one object
    // since there is only one game state, it is ok to have "static" functions. Otherwise, it would be a bad idea.
>>>>>>> 37032357764c5ebf49eeeb095414f03b362f8f92
    public static bool isValidMove(Transform piece, Transform square) // given piece and square, the function checks if piece can move to the square
    {
        if (!piece || !square) return false; // if there is no piece or no square, move is impossible. This should never happen, but better save then sorry!
        Square origin = piece.parent.GetComponent<Square>();
        Square destination = square.GetComponent<Square>();
        if (piece.name.Contains("White")) // validate moves for whites
        {
            if (piece.name.Contains("Pawn"))
            {
                if (true)  // replace that with conditions 
                {
                    return true;
                }
                else return false;

            }
        if (piece.name.Contains("King")) 
            {
                if (((origin.i+1==destination.i&&origin.j==destination.j||
                    origin.i-1 == destination.i && origin.j == destination.j||
                    origin.i+1 == destination.i && origin.j+1 == destination.j||
                    origin.i-1== destination.i && origin.j-1 == destination.j||
                    origin.i== destination.i && origin.j-1 == destination.j||
                    origin.i== destination.i && origin.j+1== destination.j||
                    origin.i-1== destination.i && origin.j+1== destination.j||
                    origin.i+1== destination.i && origin.j-1== destination.j))&& 
                    (!destination.piece||destination.piece.name.Contains("Black")))// replace that with conditions 
                {
                    return true;
                }
                else return false;
            }

            if (piece.name.Contains("Queen"))
            {
                if (((origin.i==destination.i)&&(origin.j!=destination.j)||
                       origin.j==destination.j&&origin.i!=destination.i||
                       (destination.j==destination.i)&&(destination.i-origin.i==destination.j-origin.j||
                       origin.i-destination.i == destination.j - origin.j)
                       &&!destination.piece || destination.piece.name.Contains("Black")))
                       // replace that with conditions 
                {
                    return true;
                }
                else return false;
            }

            if (piece.name.Contains("Bishop"))
            {
                if ((destination.j == destination.i) && (destination.i - origin.i == destination.j - origin.j ||
                       origin.i - destination.i == destination.j - origin.j)
                       && !destination.piece || destination.piece.name.Contains("Black"))  // replace that with conditions 
                {
                    return true;
                }
                else return false;
            }

            if (piece.name.Contains("Rook"))
            {
                if (true)  // replace that with conditions 
                {
                    return true;
                }
                else return false;
            }

            if (piece.name.Contains("Horse"))
            {
                if (true)  // replace that with conditions 
                {
                    return true;
                }
                else return false;
            }
        }
        if (piece.name.Contains("Black")) // validate moves for blacks
        {
            if (piece.name.Contains("Pawn"))
            {
                if (true)  // replace that with conditions 
                {
                    return true;
                }
                else return false;
            }


            if (piece.name.Contains("King"))
            {
                if (true)  // replace that with conditions 
                {
                    return true;
                }
                else return false;
            }

            if (piece.name.Contains("Queen"))
            {
                if (true)  // replace that with conditions 
                {
                    return true;
                }
                else return false;
            }

            if (piece.name.Contains("Bishop"))
            {
                if (true)  // replace that with conditions 
                {
                    return true;
                }
                else return false;
            }

            if (piece.name.Contains("Rook"))
            {
                if (true)  // replace that with conditions 
                {
                    return true;
                }
                else return false;
            }

            if (piece.name.Contains("Horse"))
            {
                if (true)  // replace that with conditions 
                {
                    return true;
                }
                else return false;
            }
        }

        return false;
    }
    void Start()
    {
      
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        GameObject square = Instantiate(originalSquare, chessboardParent);
                        square.GetComponent<Square>().i = i;
                        square.GetComponent<Square>().j = j;
                        square.transform.position = new Vector3(i * SQUARE_SIZE - SQUARE_SIZE * 3.5f, 1.8f, j * SQUARE_SIZE - SQUARE_SIZE * 3.5f);
                for (int k = 0; k < chessPieces.childCount; ++k)
                        {
                        if(Vector3.Distance(chessPieces.GetChild(k).position,square.transform.position)< SQUARE_SIZE / 2)
                        {
                        square.GetComponent<Square>().piece = chessPieces.GetChild(k);
                    }
                        }
                        
                        square.GetComponent<MeshRenderer>().material.color = new Color(1, 0, 0, 0);
                        square.GetComponent<Square>().i = i;
            }
                }

                Destroy(originalSquare);
     }
        

    // Update is called once per frame
    void Update()
    {
        
    }
}
    // at the beginning of the game, we procedurally construct the chessboard
    void Start()
    {
        for (int i = 0; i < 8; ++i) // in every column
        {
            for (int j = 0; j < 8; ++j) // and every row of the chessboard
            {
                GameObject square = Instantiate(originalSquare, chessboardParent); // create square
                square.GetComponent<Square>().i = i; // let square remember it's row
                square.GetComponent<Square>().j = j; // let square remember it's column
                square.transform.position = new Vector3(i * SQUARE_SIZE - SQUARE_SIZE * 3.5f, 1.8f, j * SQUARE_SIZE - SQUARE_SIZE * 3.5f); // position the square

                for (int k = 0; k < chessPieces.childCount; ++k) // look through all pieces
                {
                    if (Vector3.Distance(chessPieces.GetChild(k).position, square.transform.position) < SQUARE_SIZE/2) // and if piece is closer than half the size of square
                    {
                        square.GetComponent<Square>().piece = chessPieces.GetChild(k); // let square remember what piece is sitting on it
                        chessPieces.GetChild(k).parent = square.transform; // let piece remember what square it is sitting on (by using parent)
                    }
                }
                square.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0, 0.0f); // reset color to transparent

                chessboard[i, j] = square.transform; // put the square reference into our game state memory at a proper position
            }
        }

        Destroy(originalSquare); // once we created all squares, we don't need our initial red square

    }
}

