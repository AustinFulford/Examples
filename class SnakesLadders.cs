class SnakesLadders
{
   new public int player1Position = 0;
   new public int player2Position = 0;
   new public int turnOrder = 1;
  
    public string play(int die1, int die2)
    {
      getPositionUpdate(die1, die2);

      return "Game over!";
    }
  
    private int getPositionUpdate(int die1, int die2)
    {
      int currentPlayerPosition = 0;
      int dieSum = (die1 + die2);
      if (die1 = die2)
      {
        int playerTurn = getCurrentPlayerTurn(true);
        switch (playerTurn)
        {
        case 1:
        player1Position += (dieSum);
        currentPlayerPosition = player1Position;
        break;

        case 2:
        player2Position += (dieSum);
        currentPlayerPosition = player2Position;
        break;
        }
      }
      else 
      {
        int playerTurn = getCurrentPlayerTurn(false);
        switch (playerTurn)
        {
        case 1:
        player1Position += (dieSum);
        currentPlayerPosition = player1Position;
        break;

        case 2:
        player2Position += (dieSum);
        currentPlayerPosition = player2Position;
        break;
        }
      }
    checkForJumps(currentPlayerPosition);
    }

    private int getCurrentPlayerTurn(bool snakeeyes)
    {
      int player = 0;
      if (snakeeyes)
      {
        player = turnOrder;

      }
      else
      {
        switch (turnOrder)
        {
        case 0:
          turnOrder++
          player = turnOrder;
          break;
        case 1:
          turnOrder--
          player = turnOrder;
          break;
        }
      }
      return player;
    }

    private int checkForJumps(int currentPP)
    {
      switch(currentPP)
      {
        case 2:
        case 7:
        case 8:
        case 15:
        case 16:
        case 21:
        case 36:
        case 46:
        case 49:
        case 51:
        case 62:
        case 64:
        case 71:
        case 74:
        case 78:
        case 87:
        case 89:
        case 92:
        case 95:
        case 99:
      }
    }
  
}