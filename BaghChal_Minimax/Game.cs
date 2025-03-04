using BaghChal_Minimax;
using graphedBoard;
public class Game
{
    public void inGame()
    {
        Board board = new Board();
        MinimaxAI minmax = new MinimaxAI();

        // Declare and initialize the array of Tiger objects
        Tiger[] tigers = new Tiger[4];
        int[] tigerPositions = { 1, 5, 21, 25 };

        for (int i = 0; i < tigers.Length; i++)
        {
            tigers[i] = new Tiger();
            board.putComponentInBoard(tigers[i], tigerPositions[i]);
        }





        bool turn = false; // turn = 0 for Goat and turn = 1 for Tiger
        int avilableGoats = 20;
        while (true)
        {
            if(turn)
            {
                if(avilableGoats!=0)
                {
                    // Add goat

                    avilableGoats -= 1;
                }
                else
                {
                    // Move goat

                }
            }
            else 
            {
                // Move Tiger
            }
            // Print board
            board.PrintBoard();
            Console.ReadLine();
            //board.getGraph().traverse(1,4);
        }
    }
}

/* Core Class
   Handles game logic
   Coordinates user input and AI moves
   Maybe displays the board idk for now lol
   switches between AI and human
*/