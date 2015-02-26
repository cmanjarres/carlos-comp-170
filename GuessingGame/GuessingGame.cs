using System;

namespace IntroCS
{
	class MainClass
	{
		static void Main ()
		{
			int big;
			big = UI.PromptInt("Enter Upper Bound (or 0 to quit): ");
			while (big != 0) {
				Game (big);
				big = UI.PromptInt("Enter Upper Bound (or 0 to quit): "); ///adds the 0 to quit each time you play
			}
		}
		public static void Game (int big)
		{


			int FirstGuess;
			int Count = 0;


			Random r = new Random ();
			int secret = r.Next (1, big);



			do {
				FirstGuess = UI.PromptInt("Please guess: ");
				Count ++;
				if (FirstGuess < secret) {
				Console.WriteLine("Higher! ");
				}
				else if(FirstGuess > secret){
					Console.WriteLine("Lower! ");
				}
				else {
					Console.WriteLine("Correct! You win on guess " + Count);
				}
			} while (FirstGuess != secret);
 			



		}
	}
}
