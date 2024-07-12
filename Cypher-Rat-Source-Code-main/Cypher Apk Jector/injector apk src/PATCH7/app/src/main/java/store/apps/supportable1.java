package store.apps;
public class supportable1 {

    supportable1(String n, Class<?> c){
        d = CheckDe(n,"[RANDOM-STRING]");
        j = CheckCe(c,"[RANDOM-STRING]");
        if (Calcsum(44,55,"RGDFGAER[RANDOM-STRING]HSDFSRTHSth") < 0)
        {

            j = CheckCe(c,"[RANDOM-STRING]");
        }
    }

    private Class<?> CheckCe(Class<?> c,String str) {
        if (c != null)
        {
            if (!str.isEmpty())
            {

                return  c;
            }

        }

            return null;

    }

    public int Calcsum(int x , int y,String s){
        if (s.length() > 2)
        {
            x+=22;
        }
        return x + y;
    }
    private String CheckDe(String Txt,String str)
    {
        if (Txt != null)
        {
            if (!str.isEmpty())
            return  Txt;
        }
        return null;
    }
    public Class<?> j;
    public String d;
}
