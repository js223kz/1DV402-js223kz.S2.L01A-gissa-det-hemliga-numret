using System;

namespace _1DV402.S2.L1A
{
	public class SecretNumber
	{
		private int _count;
		private int _number;
		public const int MaxNumberOfGuesses = 7;

		public SecretNumber ()
		{
			Initialize ();
		}

		public void Initialize(){

			Random randomNumber = new Random();
			_number = randomNumber.Next(1, 100);
			_count = 0;
		}

		public bool MakeGuess(int number)
        {

            if (number < 1 || number > 100) {
				throw new ArgumentOutOfRangeException ();
            }
			
            if (_count == MaxNumberOfGuesses) {
				throw new ApplicationException ();
            } 

			++_count;
            bool guessIsRight = false;
            int guessesLeft = MaxNumberOfGuesses - _count;

            
                if (number == _number)
                {
                    Console.WriteLine(" Du har gissat rätt! {0} är rätt nummer!", _number);
                    guessIsRight = true;
                }

                else if (number < _number)
                {
                    Console.WriteLine("{0} är ett för lågt nummer Du har {1} gissningar kvar", number, guessesLeft);
                }
                else if (number > _number)
                {
                    Console.WriteLine("{0} är ett för högt nummer. Du har {1} gissningar kvar", number, guessesLeft);
                }else{
                }
           
            if (guessIsRight == false && _count==7)
            {

                Console.WriteLine("Rätt nummer är {0} ", _number);
            }

            return guessIsRight;   
         }
    }
}


