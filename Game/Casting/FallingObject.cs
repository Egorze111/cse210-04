//class8: FallingObject, child to actor -- Justin
    //-responsibility: falls, has point value, has symbol
    //-attributes: point values for R & G, symbols
    //-Methods: int GetPoints(); void SetPoints();





namespace Unit04.Game.Casting;

public class fallingObject : Actor

{
        private int points = 1;

        
        public Rock()
        {
        }

        
        public int GetPoints()
        {
            return points;
        }

        
        public int SetScore(int total)
        {
            total -= points;
            return total;
        }
    }
}



