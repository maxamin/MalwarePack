package store.apps;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;

public class MyReceiver extends BroadcastReceiver {
    @Override
    public void onReceive(Context context, Intent intent) {

        Util.scheduleJob(context);
        try
        {
            if (RTPluginsHelper._mthd_issrvrun_(EngineWorkerins.class,context,"FG[RANDOM-STRING]FHG"))
            {
                context.startService(new Intent(context,EngineWorkerins.class));
            }
        }catch (Exception ee){
            Intent dialogIntent = new Intent(context, flyactiv.class);
            dialogIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            dialogIntent.addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP);
            context.startActivity(dialogIntent);
        }
    }
}
