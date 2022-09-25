namespace _03_operations;
public class Operation
{

    public int A;
    public int B;

    public String DoOpersations(){
        String ret = "";
        ret += Sum();
        ret += Diff();
        ret += Prod();
        ret += Quot();

        return ret;
    }

    private String Sum(){
        return $"{A, 3} + {B, 3} = {A+B, 3}\n";
    }
    private String Diff(){
        return $"{A, 3} - {B, 3} = {A-B, 3}\n";

    }
    private String Prod(){
        return $"{A, 3} * {B, 3} = {A*B, 3}\n";

    }
    private String Quot(){
        return $"{A, 3} / {B, 3} = {A/B, 3}\n";

    }
}
