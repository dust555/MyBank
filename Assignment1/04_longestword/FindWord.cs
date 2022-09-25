namespace _04_longestword{
public class FindWord
{

    List<String> longestWords = new List<String>();
    String Sentence;

    public String GetLongestWord(String sentence){
        Sentence = sentence;
        longestWords.Clear();
        String[] words = Sentence.Split(" ");
        int max = 0;

        foreach(String s in words){
            if(max < s.Length){
                max = s.Length;
                longestWords.Clear();
                longestWords.Add(s);
            }
            else if(max == s.Length){
                longestWords.Add(s);
            }
        }

        return ToString();
    }

    new public String ToString(){
        String ret = "The longest words in the following sentence are:\n";
        ret += "Sentence: " + Sentence + "\n";
        ret += "Word(s): \n";
        foreach(String s in longestWords){
            ret += s + "\n";
        }
        return ret;
    }

}
}