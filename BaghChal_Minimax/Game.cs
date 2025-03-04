using graphedBoard;
public class Game
{
    public void inGame()
    {
        Board board = new Board();
        MinimaxAI minmax = new MinimaxAI();
        while (true)
        {
            board.boardMain();
            minmax.aiMain();
            Console.ReadLine();
            board.getGraph().traverse(1);
        }
    }
}

/* Core Class
   Handles game logic
   Coordinates user input and AI moves
   Maybe displays the board idk for now lol
   switches between AI and human
*/