using System;
					
public class CountLastWordLength
{
	public String getLastWordLength(string inputText){
        String [] wordList = inputText.Split(' ');
        String lastWord = wordList[wordList.Length - 1];
        String outputMsg = String.Format("The last word is {0} and has a length of {1} characters", lastWord, lastWord.Length);

        return outputMsg;
    }
	
	public static void Main()
	{
        CountLastWordLength countLastWordLength = new CountLastWordLength();
        String [] sentences = {"Hello Mr Smith", "Back to the drawing board", "Before you can say Jack Robinson"};
        foreach (string sentence in sentences){
            Console.WriteLine(countLastWordLength.getLastWordLength(sentence));
        }
	}
}