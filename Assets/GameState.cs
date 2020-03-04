using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static Transform[,] chessboard=new Transform[8,8];
    public GameObject originalSquare;
    public Transform chessboardParent;
    public Transform chessPieces;
    const int SQUARE_SIZE = 2;
    // Start is called before the first frame update
    public static bool isValidMove(Transform piece, Transform square) // given piece and square, the function checks if piece can move to the square
    {
        if (!piece || !square) return false; // if there is no piece or no square, move is impossible. This should never happen, but better save then sorry!

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

