namespace _05_stringlength;
public class StringLength
{

    public static String GetWordLenght(String word){
        int length = 0;
        foreach(char c in word){
            length++;
        }

        if(length == word.Length){
            return $"The lenght of the word '{word}' is {length} characters.";
        }
        else{
            return "Something went wrong";
        }
    }

}
