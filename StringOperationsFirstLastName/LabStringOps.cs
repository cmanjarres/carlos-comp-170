using System;

namespace IntroCS
{
	class MainClass
	{

	public static void Main (string[] args)
	{
		SentenceLength ();
		SentenceType ();
		SentenceType ();
		SentenceType ();
		SentenceType ();
			TwoNames();
			TwoNames();
	}


	public static void SentenceLength() 

	{
		string String1 = UI.PromptLine ("Enter a Sentence: ");
		Console.WriteLine ("The string is length " + String1.Length);
	}








	public static void SentenceType() 


	
	{
		string String1 = UI.PromptLine ("Enter a Sentence: ");

		char Ending = (String1 [String1.Length - 1]);
		if (Ending == '!') {
			Console.WriteLine ("The sentence is an exclamation");
		}

		else if (Ending == '?') { 
			Console.WriteLine ("The sentence is interrogotory");
		}

		else if (Ending == '.') {
			Console.WriteLine ("The sentence is declarative");
		}
		else {
			Console.WriteLine ("This is not a sentence");
		}


	}

	public static void TwoNames() 
	{





		string FullName = UI.PromptLine ("Enter full name: ");

		
		int SpaceSpot = FullName.IndexOf(" ");
			if (SpaceSpot == -1) {
				Console.WriteLine(FullName);
			}
			else {

		string FirstName = FullName.Substring(0,SpaceSpot);
			string LastName = FullName.Substring(SpaceSpot+1);
			Console.WriteLine (LastName + ", " + FirstName);
			}

	}

	public static void OneName()
	{

		//If int space == DNE 
		// then Console.WriteLine string FullName

	}

	}

}
